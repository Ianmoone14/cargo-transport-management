using CargoTransportSolution.Models;
using CargoTransportSolution.ViewModels.Storage;
using CargoTransportSolution.Views.Cargo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Windows.Input;

namespace CargoTransportSolution.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
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

        public LoginViewModel()
        {
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

                // Here you would typically navigate to the appropriate view
                // For example:
                if (user.Role == "Cargo")
                {
                    // Navigate to Cargo view
                    // You might need to implement a navigation service or use a messenger to communicate with the main application
                }
                else if (user.Role == "Storage")
                {
                    // Navigate to Storage view
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