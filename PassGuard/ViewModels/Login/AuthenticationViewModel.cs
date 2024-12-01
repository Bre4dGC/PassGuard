using CommunityToolkit.Mvvm.Input;
using PassGuard.Views.Pages.Login;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PassGuard.ViewModels.Login
{
    class AuthenticationViewModel
    {
        public ICommand RegistrationViewCommand { get; }
        public ICommand AuthenticationCommand { get; }

        public AuthenticationViewModel(NavigationService navigationService)
        {
            AuthenticationCommand = new RelayCommand(Authentication);
            RegistrationViewCommand = new RelayCommand(() => navigationService.Navigate(new RegistrationPage()));
        }

        private void Authentication()
        {

        }
    }
}
