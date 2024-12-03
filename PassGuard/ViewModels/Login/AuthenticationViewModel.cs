using CommunityToolkit.Mvvm.Input;
using PassGuard.Data;
using PassGuard.Services;
using PassGuard.Views.Windows;
using System.Windows;
using System.Windows.Input;

namespace PassGuard.ViewModels.Login
{
    class AuthenticationViewModel : BaseViewModel
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

        private IUserService _userService = new UserService(new DbContextFactory());

        public ICommand AuthenticationCommand { get; }

        public AuthenticationViewModel()
        {
            AuthenticationCommand = new RelayCommand(Authentication);
        }

        private async void Authentication()
        {
            if(await _userService.Login(Name, Password))
            {
                new MainWindow().Show();
            }
        }
    }
}
