using System.Configuration;
using System.Data;
using System.Windows;
using CargoTransportSolution.Services;
using CargoTransportSolution.ViewModels;
using CargoTransportSolution.Views;
using CargoTransportSolution.Views.Cargo;

namespace CargoTransportSolution
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {

            INavigationService navigationService = new NavigationService();
            LoginViewModel loginViewModel = new LoginViewModel(navigationService);

            LoginView loginView = new LoginView
            {
                DataContext = loginViewModel
            };
            loginView.Show();

            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false)
                {
                    loginView.Close();
                }
            };
        }
    }
}