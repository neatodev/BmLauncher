﻿using BmLauncherWForm.infrastructure;
using BmLauncherWForm.ui;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BmLauncherWForm

{
    /// <summary>
    ///     Replacement Application for the original Batman: Arkham Asylum BmLauncher
    ///     Offers more configuration options, enables compatibility with High-Res Texture Packs
    ///     and automatically takes care of the ReadOnly properties of each file, removing
    ///     any requirement to manually edit .ini files. Guarantees a much more comfortable user experience.
    ///     @author frofoo (https://steamcommunity.com/id/frofoo)
    /// </summary>
    internal static class Program
    {
        // logger for easy debugging
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static Factory MyFactory;

        public static BmLauncherForm Client;

        public static NvidiaWorker NvWorker;

        private static readonly string CurrentTime = DateTime.Now.ToString("dd-MM-yy__hh-mm-ss");

        public static readonly OperatingSystem os = Environment.OSVersion;
        public static readonly PlatformID pid = os.Platform;

        // Mutex with this applications GUID as name
        private static readonly Mutex Mutex = new Mutex(true, "{cbb275f6-724f-4e82-a403-e333dcf6c0bf}");

        [STAThread]
        private static void Main()
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                SetupLogger();
                logger.Info("Main - Starting logs at {0}, on {1}.",
                    DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("D", new CultureInfo("en-GB")));
                RunWindow();
                Mutex.ReleaseMutex();
            }
            else
            {
                NativeMethods.PostMessage((IntPtr)NativeMethods.HwndBroadcast, NativeMethods.WmShowme, IntPtr.Zero,
                    IntPtr.Zero);
            }
        }

        private static void SetupLogger()
        {
            LoggingConfiguration config = new LoggingConfiguration();
            ConsoleTarget logconsole = new ConsoleTarget("logconsole");
            if (!Directory.Exists("logs"))
            {
                Directory.CreateDirectory("logs");
            }

            FileTarget logfile = new FileTarget("logfile")
            {
                FileName = Directory.GetCurrentDirectory() + "\\logs\\bmlauncher_report__" + CurrentTime + ".log"
            };
            DirectoryInfo logDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\logs");
            DateTime oldestAllowedArchive = DateTime.Now - new TimeSpan(3, 0, 0, 0);
            foreach (FileInfo file in logDirectory.GetFiles())
            {
                if (file.CreationTime < oldestAllowedArchive)
                {
                    file.Delete();
                }
            }

            config.AddRule(LogLevel.Debug, LogLevel.Warn, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Warn, logfile);
            LogManager.Configuration = config;
        }

        private static void DetectTexmod()
        {
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] Files = d.GetFiles("*.exe");
            foreach (FileInfo f in Files)
            {
                if (f.Name == "texmod_autoload.exe")
                {
                    Factory.TexmodDetected = true;
                }
            }
        }

        public static void RunWindow()
        {
            new SysResolutions().getResolutions();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Client = new BmLauncherForm();
            DetectTexmod();
            MyFactory = new Factory(Client);
            MyFactory.readFiles();
            Application.Run(Client);
        }
    }
}