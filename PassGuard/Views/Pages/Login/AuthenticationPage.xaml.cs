using PassGuard.ViewModels.Login;
using PassGuard.Views.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PassGuard.Views.Pages.Login
{
    /// <summary>
    /// Логика взаимодействия для AuthenticationPage.xaml
    /// </summary>
    public partial class AuthenticationPage : Page
    {
        public AuthenticationPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
