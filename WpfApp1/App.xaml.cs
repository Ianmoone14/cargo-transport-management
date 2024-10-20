using System.Windows;
using CargoTransportSolution.Services;
using CargoTransportSolution.ViewModels;
using CargoTransportSolution.Views;

namespace CargoTransportSolution
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ApplicationStart();
        }

        private void ApplicationStart()
        {
            INavigationService navigationService = new NavigationService();
            LoginViewModel loginViewModel = new LoginViewModel(navigationService);

            LoginView loginView = new LoginView(loginViewModel);
            loginView.Show();

            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    loginView.Close();
                }
            };
        }
    }
}