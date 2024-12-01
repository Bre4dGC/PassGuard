using PassGuard.ViewModels.Login;
using System.Windows.Controls;

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

            DataContext = new AuthenticationViewModel(NavigationService);
        }
    }
}
