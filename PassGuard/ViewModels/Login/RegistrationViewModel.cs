using CommunityToolkit.Mvvm.Input;
using PassGuard.Data;
using PassGuard.Models;
using PassGuard.Services;
using System.Windows.Input;

namespace PassGuard.ViewModels.Login
{
    class RegistrationViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; OnPropertyChanged(); }
        }

        private ProtectionLevel _protectionLevel;
        public ProtectionLevel ProtectionLevel
        {
            get { return _protectionLevel; }
            set { _protectionLevel = value; OnPropertyChanged(); }
        }

        private IUserService _userService = new UserService(new DbContextFactory());

        public ICommand CreateUserCommand { get; }

        public RegistrationViewModel()
        {
            CreateUserCommand = new RelayCommand(Register);
        }

        private async void Register()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Password) && ConfirmPassword == Password)
            {
                await _userService.Register(
                    Name, 
                    Password,
                    ProtectionLevel);
            }
        }
    }
}
