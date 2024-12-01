using PassGuard.ViewModels.Login;
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

            DataContext = new RegistrationViewModel(NavigationService);
        }
    }
}
