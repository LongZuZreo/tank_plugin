using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Controls;

namespace tank_plugin
{
    public partial class StartUpWindow : Window
    {

        private Thread thread = null;

        public StartUpWindow()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    this.progressBar.Dispatcher.BeginInvoke((ThreadStart) delegate { this.progressBar.Value = i; });
                    Thread.Sleep(100);
                }

                startUpMainWindow();
            }));

            thread.Start();
        }

        private void startUpMainWindow()
        {
            this.progressBar.Dispatcher.Invoke(new Action(delegate
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }));
        }
        
    }
}