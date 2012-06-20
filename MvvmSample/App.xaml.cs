using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using MvvmSample.ViewModels;

namespace MvvmSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = new MainWindow();
            var viewModel = new LineOfTextViewModel();

            window.DataContext = viewModel;
            window.Show();
        }
    }
}
