using PassGuard.Views.Pages.Login;
using System.Windows;
using System.Windows.Input;

namespace PassGuard.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
                        
            LoginFrame.Content = new AuthenticationPage();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

            if(e.ClickCount == 2)
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
