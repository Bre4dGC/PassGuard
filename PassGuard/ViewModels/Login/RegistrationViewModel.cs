using CommunityToolkit.Mvvm.Input;
using PassGuard.Views.Pages.Login;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PassGuard.ViewModels.Login
{
    class RegistrationViewModel
    {
        public ICommand AuthenticationViewCommand { get; }

        public RegistrationViewModel(NavigationService navigationService)
        {
            AuthenticationViewCommand = new RelayCommand(() => navigationService.Navigate(new AuthenticationPage()));
        }
    }
}
