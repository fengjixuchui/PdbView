﻿using PdbView.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Zodiacon.WPF;

namespace PdbView {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        internal static readonly string Title = "Pdb View";

        protected override void OnStartup(StartupEventArgs e) {
            var ui = new UIServicesDefaults();
            var vm = new MainViewModel(ui);
            var win = new MainWindow { DataContext = vm };
            win.Show();
            ui.MessageBoxService.SetOwner(win);

        }

        protected override void OnExit(ExitEventArgs e) {
            MainViewModel.Instance.SaveState();
            base.OnExit(e);
        }
    }
}
