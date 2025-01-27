﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DynamicsCrm.DevKit.Shared;
using DynamicsCrm.DevKit.Shared.Models;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using DynamicsCrm.DevKit.Shared.Models.Cli;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Messages;
using DynamicsCrm.DevKit.Shared.Helper;

namespace DynamicsCrm.DevKit.Cli.Tasks
{
    class TaskDataProvider
    {
        private CrmServiceClient crmServiceClient;
        private string currentDirectory;
        private CommandLineArgs arguments;
        private const string LOG = "[DATAPROVIDER]";
        private JsonDataProvider json;
        private Guid SolutionId = Guid.Empty;
        private string Prefix = string.Empty;
        private string DataSourceName = string.Empty;

        public TaskDataProvider(CrmServiceClient crmServiceClient, string currentDirectory, CommandLineArgs arguments)
        {
            // /conn:"AuthType=ClientSecret;Url=https://dev-devkit.crm5.dynamics.com;ClientId=e31fc7d6-4dce-46e3-8677-04ab0a2968e3;ClientSecret=?-iwRSB0te8o]pHX_yVQLJnUqziB1E0h;" /json:"..\DynamicsCrm.DevKit.Cli.json" /type:"dataproviders" /profile:"DEBUG"
            // /sdklogin:"yes" /json:"..\DynamicsCrm.DevKit.Cli.json" /type:"dataproviders" /profile:"DEBUG"

            this.crmServiceClient = crmServiceClient;
            this.currentDirectory = currentDirectory;
            this.arguments = arguments;
            var jsonFile = Path.Combine(currentDirectory, arguments.Json);
            this.json = SimpleJson.DeserializeObject<Json>(File.ReadAllText(jsonFile))
                .dataproviders.FirstOrDefault(x => x.profile == arguments.Profile);
        }

        public void Run()
        {
            CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorGreen, "START ", CliLog.ColorMagenta, "DATA-PROVIDER");
            CliLog.WriteLine(CliLog.ColorWhite, "|");

            if (!IsValid()) return;

            foreach (var file in DataProviderFiles)
            {
                RegisterDataProvider(file);
            }

            CliLog.WriteLine(CliLog.ColorWhite, "|");
            CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorGreen, "END ", CliLog.ColorMagenta, "DATA-PROVIDER");
        }

        private bool IsValid()
        {
            if (json == null)
                throw new Exception($"{LOG} 'profile' not found: '{arguments.Profile}'. Please check DynamicsCrm.DevKit.Cli.json file.");
            if (json.solution.Length == 0 || json.solution == "???")
                throw new Exception($"{LOG} 'solution' 'empty' or '???'. Please check DynamicsCrm.DevKit.Cli.json file.");
            if (json.datasource == null || json.datasource.Length == 0 || json.datasource == "???")
                throw new Exception($"{LOG} 'datasource' 'empty' or '???'. Please check DynamicsCrm.DevKit.Cli.json file.");
            if (!XrmHelper.IsExistSolution(crmServiceClient, json.solution, out var solutionId, out var prefix))
                throw new Exception($"{LOG} solution '{json.solution}' not exist");
            SolutionId = solutionId;
            Prefix = prefix;
            DataSourceName = json.datasource.ToLower().StartsWith(prefix.ToLower()) ? json.datasource : $"{Prefix}{json.datasource}";
            if (!XrmHelper.IsExistDataSource(crmServiceClient, $"{DataSourceName}"))
                throw new Exception($"{LOG} name '{json.datasource}' not exist with prefix: {Prefix}");
            return true;
        }

        private IEnumerable<string> DataProviderFiles
        {
            get
            {
                var folder = Path.Combine(currentDirectory, json.folder);
                var includefiles = new List<string>();
                foreach (var includefile in json.includefiles)
                    includefiles.AddRange(Directory.GetFiles(folder, includefile).ToList());
                foreach (var includefile in json.includefiles)
                {
                    var other = includefile.Replace("*.", string.Empty);
                    includefiles.AddRange(Directory.GetFiles(folder, other).ToList());
                }
                var excludefiles = new List<string>();
                foreach (var excludefile in json.excludefiles)
                    excludefiles.AddRange(Directory.GetFiles(folder, excludefile).ToList());
                foreach (var excludefile in json.excludefiles)
                {
                    var other = excludefile.Replace("*.", string.Empty);
                    excludefiles.AddRange(Directory.GetFiles(folder, other).ToList());
                }
                var assemblies = includefiles.Where(file => !excludefiles.Contains(file)).ToList();
                return assemblies;
            }
        }

        private class DataProviderEvent
        {
            public Guid PluginTypeId { get; set; }
            public string Message { get; set; }
        }

        private void RegisterDataProvider(string pluginFile)
        {
            var assemblyFilePath = new FileInfo(pluginFile);
            Assembly assembly = null;
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
            assembly = Assembly.ReflectionOnlyLoadFrom(pluginFile);
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= CurrentDomain_ReflectionOnlyAssemblyResolve;
            if (assembly == null) return;
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
            var pluginTypes = assembly.DefinedTypes.Where(p =>
                p.GetInterfaces().FirstOrDefault(a => a.Name == typeof(IPlugin).Name) != null);
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= CurrentDomain_ReflectionOnlyAssemblyResolve;
            var plugins = (from pluginType in pluginTypes
                           where pluginType.IsAbstract == false
                           select pluginType
                ).ToList();
            if (!plugins.Any()) return;
            var pluginEntity = RegisterAssembly(assemblyFilePath, assembly, plugins);
            if (pluginEntity == null) return;
            AddAssemblyToSolution(pluginEntity);
            var dataProviderEvents = new List<DataProviderEvent>();
            foreach (var plugin in plugins)
            {
                var pluginAttributes = plugin.GetCustomAttributesData()
                                      .Where(a => a.AttributeType.Name == typeof(CrmPluginRegistrationAttribute).Name);
                var customAttributeDatas = pluginAttributes as CustomAttributeData[] ?? pluginAttributes.ToArray();
                var isDataProvider = false;
                foreach (var customAttribute in customAttributeDatas)
                {
                    var constructorArgumentPluginType = customAttribute.ConstructorArguments.FirstOrDefault(x => x.ArgumentType.Name == "PluginType");
                    var namedArgumentPluginType = customAttribute.NamedArguments.FirstOrDefault(x => x.MemberName == "PluginType");
                    if (
                        (constructorArgumentPluginType.Value != null && (PluginType)(int)constructorArgumentPluginType.Value == PluginType.DataProvider) ||
                        (namedArgumentPluginType.TypedValue != null && (PluginType)(int)namedArgumentPluginType.TypedValue.Value == PluginType.DataProvider)
                       )
                    {
                        isDataProvider = true;
                        break;
                    }
                }
                if (isDataProvider)
                {
                    foreach (var customAttribute in customAttributeDatas)
                    {
                        var constructorArgumentMessage = customAttribute.ConstructorArguments.Count >= 2 ? customAttribute.ConstructorArguments[1] : new CustomAttributeTypedArgument();
                        var namedArgumentMessage = customAttribute.NamedArguments.FirstOrDefault(x => x.MemberName == "Message");
                        if (constructorArgumentMessage.Value != null || namedArgumentMessage.TypedValue != null)
                        {
                            var pluginTypeId = RegisterPluginType(pluginEntity, plugin);
                            if (constructorArgumentMessage.Value != null)
                            {
                                dataProviderEvents.Add(new DataProviderEvent
                                {
                                    PluginTypeId = pluginTypeId,
                                    Message = (string)constructorArgumentMessage.Value
                                });
                                break;
                            }
                            else if (namedArgumentMessage.TypedValue != null)
                            {
                                dataProviderEvents.Add(new DataProviderEvent
                                {
                                    PluginTypeId = pluginTypeId,
                                    Message = (string)namedArgumentMessage.TypedValue.Value
                                });
                                break;
                            }
                        }
                    }
                }
            }
            if (dataProviderEvents.Count > 0)
            {
                if (IsOkForRegisterDataProvider(dataProviderEvents))
                {
                    var assemblyName = assembly.GetName().Name;
                    RegisterDataProvider(dataProviderEvents, assemblyName);
                }
            }
        }

        private void RegisterDataProvider(List<DataProviderEvent> dataProviderEvents, string dataProviderName)
        {
            var entity = new Entity("entitydataprovider");
            entity.Attributes.Add("name", dataProviderName);
            entity.Attributes.Add("datasourcelogicalname", $"{DataSourceName.ToLower()}");
            entity.Attributes.Add("solutionid", SolutionId);

            var retrieve = dataProviderEvents.Where(x => x.Message == "Retrieve").FirstOrDefault();
            if (retrieve == null)
                entity.Attributes.Add("retrieveplugin", new Guid("{c1919979-0021-4f11-a587-a8f904bdfdf9}"));
            else
                entity.Attributes.Add("retrieveplugin", retrieve.PluginTypeId);

            var retrievemultiple = dataProviderEvents.Where(x => x.Message == "RetrieveMultiple").FirstOrDefault();
            if (retrievemultiple == null)
                entity.Attributes.Add("retrievemultipleplugin", new Guid("{c1919979-0021-4f11-a587-a8f904bdfdf9}"));
            else
                entity.Attributes.Add("retrievemultipleplugin", retrievemultiple.PluginTypeId);
            if (XrmHelper.IsVirtualTableSupportCRUD(crmServiceClient))
            {
                var create = dataProviderEvents.Where(x => x.Message == "Create").FirstOrDefault();
                if (create == null)
                    entity.Attributes.Add("createplugin", new Guid("{c1919979-0021-4f11-a587-a8f904bdfdf9}"));
                else
                    entity.Attributes.Add("createplugin", create.PluginTypeId);

                var update = dataProviderEvents.Where(x => x.Message == "Update").FirstOrDefault();
                if (update == null)
                    entity.Attributes.Add("updateplugin", new Guid("{c1919979-0021-4f11-a587-a8f904bdfdf9}"));
                else
                    entity.Attributes.Add("updateplugin", update.PluginTypeId);

                var delete = dataProviderEvents.Where(x => x.Message == "Delete").FirstOrDefault();
                if (delete == null)
                    entity.Attributes.Add("deleteplugin", new Guid("{c1919979-0021-4f11-a587-a8f904bdfdf9}"));
                else
                    entity.Attributes.Add("deleteplugin", delete.PluginTypeId);
            }

            var entityDataProvider = GetEntityDataProviderId(dataProviderName);
            if (entityDataProvider == null)
            {

                var request = new CreateRequest();
                if (request.Parameters == null)
                    request.Parameters = new ParameterCollection();
                request.Target = entity;
                request.Parameters.Add("SuppressDuplicateDetection", true);
                request.Parameters.Add("SolutionUniqueName", json.solution);
                CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, " Registering", CliLog.ColorGreen, " Data Provider: ", CliLog.ColorCyan, $"{dataProviderName}");
                crmServiceClient.Execute(request);
            }
            else
            {
                var entitydataproviderid = entityDataProvider.GetAttributeValue<Guid?>("entitydataproviderid");
                var retrieveplugin = entityDataProvider.GetAttributeValue<Guid?>("retrieveplugin");
                var retrievemultipleplugin = entityDataProvider.GetAttributeValue<Guid?>("retrievemultipleplugin");
                var createplugin = entityDataProvider.GetAttributeValue<Guid?>("createplugin");
                var deleteplugin = entityDataProvider.GetAttributeValue<Guid?>("deleteplugin");
                var updateplugin = entityDataProvider.GetAttributeValue<Guid?>("updateplugin");
                if (retrievemultipleplugin != entity.GetAttributeValue<Guid>("retrievemultipleplugin") ||
                    retrieveplugin != entity.GetAttributeValue<Guid>("retrieveplugin") ||
                    createplugin != entity.GetAttributeValue<Guid>("createplugin") ||
                    deleteplugin != entity.GetAttributeValue<Guid>("deleteplugin") ||
                    updateplugin != entity.GetAttributeValue<Guid>("updateplugin")
                    )
                {
                    entity.Attributes.Add("entitydataproviderid", entitydataproviderid.Value);
                    var request = new UpdateRequest
                    {
                        Target = entity
                    };
                    CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, " Updating", CliLog.ColorGreen, " Data Provider: ", CliLog.ColorCyan, $"{dataProviderName}");
                    crmServiceClient.Execute(request);
                }
            }
        }

        private Entity GetEntityDataProviderId(string dataProviderName)
        {
            var fetchData = new
            {
                datasourcelogicalname = $"{DataSourceName.ToLower()}",
                ismanaged = "0",
                iscustomizable = "1",
                name = dataProviderName
            };
            var fetchXml = $@"
<fetch>
  <entity name='entitydataprovider'>
    <attribute name='entitydataproviderid' />
    <attribute name='retrievemultipleplugin' />
    <attribute name='createplugin' />
    <attribute name='deleteplugin' />
    <attribute name='updateplugin' />
    <attribute name='retrieveplugin' />
    <filter>
      <condition attribute='datasourcelogicalname' operator='eq' value='{fetchData.datasourcelogicalname}'/>
      <condition attribute='ismanaged' operator='eq' value='{fetchData.ismanaged}'/>
      <condition attribute='iscustomizable' operator='eq' value='{fetchData.iscustomizable}'/>
      <condition attribute='name' operator='eq' value='{fetchData.name}'/>
    </filter>
  </entity>
</fetch>";
            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            if (rows.Entities.Count != 1) return null;
            return rows.Entities[0];
        }

        private bool IsOkForRegisterDataProvider(List<DataProviderEvent> dataProviderEvents)
        {
            var count = dataProviderEvents.Count(x => x.Message == "Retrieve");
            if (count != 0 && count != 1) throw new Exception($"{LOG} multiple message VirtualTablePlugin.Retrieve found");
            count = dataProviderEvents.Count(x => x.Message == "RetrieveMultiple");
            if (count != 0 && count != 1) throw new Exception($"{LOG} multiple message VirtualTablePlugin.RetrieveMultiple found");
            if (XrmHelper.IsVirtualTableSupportCRUD(crmServiceClient))
            {
                count = dataProviderEvents.Count(x => x.Message == "Create");
                if (count != 0 && count != 1) throw new Exception($"{LOG} multiple message VirtualTablePlugin.Create found");
                count = dataProviderEvents.Count(x => x.Message == "Update");
                if (count != 0 && count != 1) throw new Exception($"{LOG} multiple message VirtualTablePlugin.Update found");
                count = dataProviderEvents.Count(x => x.Message == "Delete");
                if (count != 0 && count != 1) throw new Exception($"{LOG} multiple message VirtualTablePlugin.Delete found");
            }
            return true;
        }

        private Guid RegisterPluginType(Entity pluginEntity, TypeInfo plugin)
        {
            var fetchData = new
            {
                typename = plugin.FullName
            };
            var fetchXml = $@"
<fetch>
  <entity name='plugintype'>
    <attribute name='plugintypeid' />
    <filter type='and'>
      <condition attribute='typename' operator='eq' value='{fetchData.typename}'/>
    </filter>
  </entity>
</fetch>";
            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            if (rows.Entities.Count == 0)
            {
                var pluginType = new Entity("plugintype")
                {
                    ["name"] = plugin.FullName,
                    ["pluginassemblyid"] = new EntityReference("pluginassembly", Guid.Parse(pluginEntity["pluginassemblyid"].ToString())),
                    ["typename"] = plugin.FullName,
                    ["friendlyname"] = plugin.FullName
                };
                CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, " Registering", CliLog.ColorGreen, " Type: ", CliLog.ColorCyan, $"{plugin.FullName}");
                return crmServiceClient.Create(pluginType);
            }
            else
                return rows.Entities[0].Id;
        }

        private Entity RegisterAssembly(FileSystemInfo assemblyFilePath, Assembly assembly, IEnumerable<Type> plugins)
        {
            var assemblyProperties = assembly.GetName().FullName
                .Split(",= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var assemblyName = assembly.GetName().Name;
            var fetchData = new
            {
                name = assemblyProperties[0]
            };
            var fetchXml = $@"
<fetch>
  <entity name='pluginassembly'>
    <attribute name='pluginassemblyid' />
    <attribute name='content' />
    <filter type='and'>
      <condition attribute='name' operator='eq' value='{fetchData.name}'/>
    </filter>
  </entity>
</fetch>";
            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            var pluginAssemblyId = Guid.Empty;
            var existingContent = string.Empty;
            if (rows.Entities.Count > 0)
            {
                var entity = rows.Entities[0];
                pluginAssemblyId = entity.Id;
                existingContent = entity.GetAttributeValue<string>("content");
            }
            var content = Convert.ToBase64String(File.ReadAllBytes(assemblyFilePath.FullName));
            if (content == existingContent) return null;
            var plugin = new Entity("pluginassembly")
            {
                ["content"] = content,
                ["name"] = assemblyProperties[0],
                ["culture"] = assemblyProperties[4],
                ["version"] = assemblyProperties[2],
                ["publickeytoken"] = assemblyProperties[6],
                ["sourcetype"] = new OptionSetValue(0),/* 0 = database */
                ["isolationmode"] = new OptionSetValue(2)/* 2 = sandbox */
            };
            if (pluginAssemblyId == Guid.Empty)
            {
                CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, "Registering", CliLog.ColorGreen, " Assembly: ", CliLog.ColorCyan, $"{assemblyProperties[0]}");
                pluginAssemblyId = crmServiceClient.Create(plugin);
                plugin["pluginassemblyid"] = pluginAssemblyId;
            }
            else
            {
                CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, "Updating", CliLog.ColorGreen, " Assembly: ", CliLog.ColorCyan, $"{assemblyProperties[0]}");
                plugin["pluginassemblyid"] = pluginAssemblyId;
                try
                {
                    crmServiceClient.Update(plugin);
                }
                catch (FaultException fe)
                {
                    CliLog.WriteLine();
                    CliLog.WriteLine();
                    CliLog.WriteLine(ConsoleColor.White, fe.Message);
                    CliLog.WriteLine();
                    CliLog.WriteLine();
                    CliLog.WriteLine(ConsoleColor.Red, "!!! DEPLOY DATA-PROVIDER FAILED !!!");
                    throw;
                }
            }
            return plugin;
        }

        private void AddAssemblyToSolution(Entity plugin)
        {
            var fetchData = new
            {
                objectid = plugin["pluginassemblyid"].ToString(),
                componenttype = 91,
                uniquename = json.solution
            };
            var fetchXml = $@"
<fetch>
  <entity name='solutioncomponent'>
    <attribute name='solutioncomponentid' />
    <filter type='and'>
      <condition attribute='objectid' operator='eq' value='{fetchData.objectid}'/>
      <condition attribute='componenttype' operator='eq' value='{fetchData.componenttype}'/>
    </filter>
    <link-entity name='solution' from='solutionid' to='solutionid'>
      <filter type='and'>
        <condition attribute='uniquename' operator='eq' value='{fetchData.uniquename}'/>
      </filter>
    </link-entity>
  </entity>
</fetch>";
            var rows = crmServiceClient.RetrieveMultiple(new FetchExpression(fetchXml));
            if (rows.Entities.Count == 0)
            {
                var request = new AddSolutionComponentRequest
                {
                    AddRequiredComponents = true,
                    ComponentType = 91,
                    ComponentId = Guid.Parse(plugin["pluginassemblyid"].ToString()),
                    SolutionUniqueName = json.solution
                };
                CliLog.WriteLine(CliLog.ColorWhite, "|", CliLog.ColorRed, " Adding", CliLog.ColorGreen, " Assembly: ", CliLog.ColorCyan, $"{plugin["name"]} ", CliLog.ColorGreen, "to solution: ", CliLog.ColorCyan, $"{json.solution}");
                crmServiceClient.Execute(request);
            }
        }

        private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly assembly;
            var parts = args.Name.Split(',');
            switch (parts[0])
            {
                case "Microsoft.Xrm.Sdk":
                    assembly = Assembly.ReflectionOnlyLoad(parts[0].Trim());
                    break;
                default:
                    assembly = Assembly.ReflectionOnlyLoad(args.Name);
                    break;
            }
            return assembly;
        }
    }
}
