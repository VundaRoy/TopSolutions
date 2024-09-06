using System.Configuration;
using System.Data;
using System.Windows;
using UltraWPFApp.ViewModel;

namespace UltraWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new();
            UserViewModel VM = new();
            window.DataContext = VM;
            window.Show();
        }
    }

}
