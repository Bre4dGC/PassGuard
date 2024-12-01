using Dark.Net;
using System.Drawing;
using System.Windows;

namespace PassGuard.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DarkNet.Instance.SetWindowThemeWpf(this, Theme.Dark, new ThemeOptions
            {
                TitleBarBackgroundColor = Color.FromArgb(25, 38, 52)
            });

            DarkNet.Instance.SetWindowThemeWpf(this, Theme.Auto);
        }
    }
}