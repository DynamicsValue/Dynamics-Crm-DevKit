﻿using CmdLine;
using DynamicsCrm.DevKit.Cli.Tasks;
using DynamicsCrm.DevKit.Lib.Forms;
using DynamicsCrm.DevKit.Shared;
using DynamicsCrm.DevKit.Shared.Models;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DynamicsCrm.DevKit.Cli
{
    public class Program
    {
        private static CrmServiceClient CrmServiceClient { get; set; }

        [STAThread]
        public static void Main(string[] args)
        {
            var arguments = CommandLine.Parse<CommandLineArgs>();
            RunCli(arguments);
        }

        static void RunCli(CommandLineArgs arguments)
        {
            CliLog.SetupCliLog();
#if DEBUG
            //CliLog.WriteLineChanged(ConsoleColor.DarkMagenta, new string('█', CliLog.StarLength));
            //CliLog.WriteLine(ConsoleColor.Red, "!!! DEBUG !!!");
            //CliLog.WriteLineChanged(ConsoleColor.DarkMagenta, new string('█', CliLog.StarLength));
#endif
            CliLog.WriteLine(ConsoleColor.Green, " ____                              _           ____                  ____             _  ___ _     ____ _ _ ");
            CliLog.WriteLine(ConsoleColor.Green, "|  _ \\ _   _ _ __   __ _ _ __ ___ (_) ___ ___ / ___|_ __ _ __ ___   |  _ \\  _____   _| |/ (_) |_  / ___| (_)");
            CliLog.WriteLine(ConsoleColor.Green, "| | | | | | | '_ \\ / _` | '_ ` _ \\| |/ __/ __| |   | '__| '_ ` _ \\  | | | |/ _ \\ \\ / / ' /| | __|| |   | | |");
            CliLog.WriteLine(ConsoleColor.Green, "| |_| | |_| | | | | (_| | | | | | | | (__\\__ \\ |___| |  | | | | | |_| |_| |  __/\\ V /| . \\| | |_ | |___| | |");
            CliLog.WriteLine(ConsoleColor.Green, "|____/ \\__, |_| |_|\\__,_|_| |_| |_|_|\\___|___/\\____|_|  |_| |_| |_(_)____/ \\___| \\_/ |_|\\_\\_|\\__(_)____|_|_|");
            CliLog.WriteLine(ConsoleColor.Green, "       |___/                        ", ConsoleColor.White, "https://github.com/phuocle/Dynamics-Crm-DevKit", ConsoleColor.Blue, $" {Const.Version}", ConsoleColor.White, " Build: ", ConsoleColor.Blue, Const.Build);
            CliLog.WriteLine(ConsoleColor.White, "|");
            if (IsValid(arguments))
            {
                CliTask.Run(arguments);
            }
#if DEBUG
            //CliLog.WriteLineChanged(ConsoleColor.DarkMagenta, new string('█', CliLog.StarLength));
            //CliLog.WriteLine(ConsoleColor.Red, "!!! FINISHED !!!");
            //CliLog.WriteLineChanged(ConsoleColor.DarkMagenta, new string('█', CliLog.StarLength));
            Console.ReadKey();
#endif
        }

        private static bool IsValid(CommandLineArgs arguments)
        {
            CrmServiceClient = null;
            CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "Current Directory ", ConsoleColor.Blue, "Path=", ConsoleColor.White, arguments.CurrentDirectory);
            CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "DynamicsCrm.DevKit.Cli.exe ", ConsoleColor.Blue, "Path=", ConsoleColor.White, Assembly.GetExecutingAssembly().Location);
            if (!File.Exists(arguments.JsonFile)) {
                CliLog.WriteLineError(ConsoleColor.Yellow, $"/json:{arguments.Json} [{arguments.JsonFile}] not found !!!");
                return false;
            }
            CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "DynamicsCrm.DevKit.Cli.json ", ConsoleColor.Blue, "Path=", ConsoleColor.White, arguments.JsonFile);
            if (arguments.IsSdkLogin)
            {
                CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "Arguments: ",
                    ConsoleColor.Blue, "/sdklogin:", ConsoleColor.White, "\"yes\"", " ",
                    ConsoleColor.Blue, "/json:", ConsoleColor.White, "\"" + arguments.Json, "\" ",
                    ConsoleColor.Blue, "/type:", ConsoleColor.White, "\"" + arguments.Type, "\" ",
                    ConsoleColor.Blue, "/profile:", ConsoleColor.White, "\"" + arguments.Profile + "\""
                );
            }
            else
            {
                if (arguments.Connection.Length == 0)
                {
                    CliLog.WriteLineError(ConsoleColor.Yellow, $"/conn: required !!!");
                    return false;
                }
                CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "Arguments: ",
                    ConsoleColor.Blue, "/conn:", ConsoleColor.White, "\"" + XrmHelper.BuildConnectionStringLog(arguments.Connection), "\" ",
                    ConsoleColor.Blue, "/json:", ConsoleColor.White, "\"" + arguments.Json, "\" ",
                    ConsoleColor.Blue, "/type:", ConsoleColor.White, "\"" + arguments.Type, "\" ",
                    ConsoleColor.Blue, "/profile:", ConsoleColor.White, "\"" + arguments.Profile + "\""
                );
            }
            if (arguments.Type.Length == 0)
            {
                CliLog.WriteLineError(ConsoleColor.Yellow, $"/type: required !!!");
                return false;
            }
            if (arguments.Profile.Length == 0)
            {
                CliLog.WriteLineError(ConsoleColor.Yellow, $"/profile: required !!!");
                return false;
            }
            if (arguments.IsSdkLogin)
            {
                var ignoreCliTypes = new List<string>() { nameof(CliType.proxytypes) };
                if (!ignoreCliTypes.Any(x => arguments.Type == x))
                {
                    if (!IsConnectedDynamics365BySdkLogin())
                    {
                        CliLog.WriteLineError(ConsoleColor.Yellow, $"SdkLogin failed !!!");
                        return false;
                    }
                }
            }
            else
            {
                CrmServiceClient = XrmHelper.IsConnected(arguments.Connection);
                if (CrmServiceClient == null)
                {
                    CliLog.WriteLineError(ConsoleColor.Yellow, $"Connection String failed !!!");
                    return false;
                }
            }
            arguments.CrmServiceClient = CrmServiceClient;
            CliLog.WriteLineWarning(ConsoleColor.Green, "Connected: ", ConsoleColor.White, XrmHelper.ConnectedUrl(CrmServiceClient));
            CliLog.WriteLine(ConsoleColor.White, "|", ConsoleColor.Green, "Connection Timeout: ", ConsoleColor.White, CrmServiceClient.MaxConnectionTimeout.TotalSeconds.ToString("#,###"), ConsoleColor.Green, " (seconds)");
            CliLog.WriteLine(ConsoleColor.White, "|");
            return true;
        }

        private static bool IsConnectedDynamics365BySdkLogin()
        {
            CrmServiceClient.MaxConnectionTimeout = new TimeSpan(1, 0, 0);
            var loginForm = new FormLogin(true);
            loginForm.ConnectionToCrmCompleted += loginForm_ConnectionToCrmCompleted;
            loginForm.ShowDialog();
            if (loginForm.CrmConnectionMgr != null && loginForm.CrmConnectionMgr.CrmSvc != null && loginForm.CrmConnectionMgr.CrmSvc.IsReady)
            {
                CrmServiceClient = loginForm.CrmConnectionMgr.CrmSvc;
                return true;
            }
            return false;
        }

        private static void loginForm_ConnectionToCrmCompleted(object sender, EventArgs e)
        {
            if (sender is FormLogin login)
            {
                login.Close();
            }
        }
    }
}