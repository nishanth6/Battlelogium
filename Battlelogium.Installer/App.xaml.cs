﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Battlelogium.Installer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 1)
            {
                new UIInstaller().Show();
                return;
            }
            string currentversion = args[1];
            string installPath = args[2];
            int battlelogiumPID = int.Parse(args[3]);
            new UIUpdater(currentversion, installPath, battlelogiumPID).Show();
        }
    }
}