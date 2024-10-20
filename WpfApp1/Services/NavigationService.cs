// Create this in a new file, e.g., NavigationService.cs
using System;
using System.Windows;

namespace CargoTransportSolution.Services
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : Window;
    }

    public class NavigationService : INavigationService
    {
        public void NavigateTo<T>() where T : Window
        {
            var window = Activator.CreateInstance<T>();
            window.Show();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = window;
        }
    }
}