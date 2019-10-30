using System;
using System.Windows;

namespace tank_plugin
{
    
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += CurrentDomain_UnhandledException;

        }
        private  void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
            {
                var ex = (Exception)e.ExceptionObject;
                MessageBox.Show($"错误信息:{ex.Message}\r\n调用堆栈:{ex.StackTrace}\r\n终止标志:{e.IsTerminating}");
            }
    }
 

}