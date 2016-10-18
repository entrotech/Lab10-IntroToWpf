using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfIntroClient
{
    public class App : Application
    {
        [STAThread]
        static void Main()
        {
            App app = new App();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow win = new MainWindow();
            win.Show();
        }

        private App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Unhandled Exception",
                MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;

        }

        

        //private void App_Startup(object sender, StartupEventArgs e)
        //{
        //    MessageBox.Show("Thank you for using this application!", 
        //        "OnExit Event Occured",
        //        MessageBoxButton.OK, MessageBoxImage.Exclamation);
        //}


    }
}
