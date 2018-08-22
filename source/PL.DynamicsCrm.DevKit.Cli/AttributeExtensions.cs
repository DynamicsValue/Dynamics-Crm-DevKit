﻿using System;
using System.Linq;
using System.Reflection;

namespace PL.DynamicsCrm.DevKit.Cli
{
    public static class AttributeExtensions
    {
        public static CrmPluginRegistrationAttribute CreateFromData(this CustomAttributeData data)
        {
            CrmPluginRegistrationAttribute attribute = null;
            var arguments = data.ConstructorArguments.ToArray();
            // determine which constructor is being used by the first type
            if (data.ConstructorArguments.Count == 8 && data.ConstructorArguments[0].ArgumentType.Name == "String")
                attribute = new CrmPluginRegistrationAttribute(
                    (string) arguments[0].Value,
                    (string) arguments[1].Value,
                    (StageEnum) Enum.ToObject(typeof(StageEnum), (int) arguments[2].Value),
                    (ExecutionModeEnum) Enum.ToObject(typeof(ExecutionModeEnum), (int) arguments[3].Value),
                    (string) arguments[4].Value,
                    (string) arguments[5].Value,
                    (int) arguments[6].Value,
                    (IsolationModeEnum) Enum.ToObject(typeof(IsolationModeEnum), (int) arguments[7].Value)
                );
            else if (data.ConstructorArguments.Count == 8 &&
                     data.ConstructorArguments[0].ArgumentType.Name == "MessageNameEnum")
                attribute = new CrmPluginRegistrationAttribute(
                    (MessageNameEnum) Enum.ToObject(typeof(MessageNameEnum), (int) arguments[0].Value),
                    (string) arguments[1].Value,
                    (StageEnum) Enum.ToObject(typeof(StageEnum), (int) arguments[2].Value),
                    (ExecutionModeEnum) Enum.ToObject(typeof(ExecutionModeEnum), (int) arguments[3].Value),
                    (string) arguments[4].Value,
                    (string) arguments[5].Value,
                    (int) arguments[6].Value,
                    (IsolationModeEnum) Enum.ToObject(typeof(IsolationModeEnum), (int) arguments[7].Value)
                );
            else if (data.ConstructorArguments.Count == 5 && data.ConstructorArguments[0].ArgumentType.Name == "String")
                attribute = new CrmPluginRegistrationAttribute(
                    (string) arguments[0].Value,
                    (string) arguments[1].Value,
                    (string) arguments[2].Value,
                    (string) arguments[3].Value,
                    (IsolationModeEnum) Enum.ToObject(typeof(IsolationModeEnum), (int) arguments[4].Value)
                );

            foreach (var namedArgument in data.NamedArguments)
                switch (namedArgument.MemberName)
                {
                    case "Id":
                        attribute.Id = (string) namedArgument.TypedValue.Value;
                        break;
                    case "FriendlyName":
                        attribute.FriendlyName = (string) namedArgument.TypedValue.Value;
                        break;
                    case "GroupName":
                        attribute.FriendlyName = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Image1Name":
                        attribute.Image1Name = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Image1Attributes":
                        attribute.Image1Attributes = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Image2Name":
                        attribute.Image2Name = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Image2Attributes":
                        attribute.Image2Attributes = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Image1Type":
                        attribute.Image1Type = (ImageTypeEnum) namedArgument.TypedValue.Value;
                        break;
                    case "Image2Type":
                        attribute.Image2Type = (ImageTypeEnum) namedArgument.TypedValue.Value;
                        break;
                    case "Description":
                        attribute.Description = (string) namedArgument.TypedValue.Value;
                        break;
                    case "DeleteAsyncOperation":
                        attribute.DeleteAsyncOperation = (bool) namedArgument.TypedValue.Value;
                        break;
                    case "UnSecureConfiguration":
                        attribute.UnSecureConfiguration = (string) namedArgument.TypedValue.Value;
                        break;
                    case "SecureConfiguration":
                        attribute.SecureConfiguration = (string) namedArgument.TypedValue.Value;
                        break;
                    case "Offline":
                        attribute.Offline = (bool) namedArgument.TypedValue.Value;
                        break;
                    case "Server":
                        attribute.Server = (bool) namedArgument.TypedValue.Value;
                        break;
                    case "Action":
                        attribute.Action = (PluginStepOperationEnum) namedArgument.TypedValue.Value;
                        break;
                }
            return attribute;
        }
    }
}