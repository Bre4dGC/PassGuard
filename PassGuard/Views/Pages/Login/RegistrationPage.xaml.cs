using System.Windows;
using System.Windows.Controls;

namespace PassGuard.Views.Pages.Login
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthenticationPage());
        }        
    }
}
