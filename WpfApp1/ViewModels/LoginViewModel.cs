using CargoTransportSolution.Models;
using CargoTransportSolution.Services;
using CargoTransportSolution.Views.Cargo;
using CargoTransportSolution.Views.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Windows.Input;

namespace CargoTransportSolution.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private List<UserModel> _users;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public SecureString Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); }
        }

        public bool IsVisible
        {
            get => _isViewVisible;
            set { _isViewVisible = value; OnPropertyChanged(nameof(IsVisible)); }
        }

        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPassCommand("", ""));

            // Initialize hardcoded users
            _users = new List<UserModel>
            {
                new UserModel { Username = "cargo", Password = "cargo123", Role = "Cargo" },
                new UserModel { Username = "storage", Password = "storage123", Role = "Storage" }
            };
        }

        private void ExecuteLoginCommand(object obj)
        {
            var user = _users.FirstOrDefault(u => u.Username == Username && u.Password == new System.Net.NetworkCredential(string.Empty, Password).Password);

            if (user != null)
            {
                ErrorMessage = string.Empty;
                IsVisible = false; // This will hide the login window

                // Navigate to the appropriate view based on the user's role
                if (user.Role == "Cargo")
                {
                    _navigationService.NavigateTo<MainView>();
                }
                else if (user.Role == "Storage")
                {
                    _navigationService.NavigateTo<StorageMainView>();
                }
            }
            else
            {
                ErrorMessage = "Invalid username or password";
            }
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            return !string.IsNullOrWhiteSpace(Username) && Username.Length >= 3 && Password != null && Password.Length >= 3;
        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            // Implement password recovery logic here
            // For now, we'll just set an error message
            ErrorMessage = "Password recovery not implemented yet.";
        }
    }
}