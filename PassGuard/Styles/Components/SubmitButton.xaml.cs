using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PassGuard.Styles.Components
{
    /// <summary>
    /// Логика взаимодействия для SubmitButton.xaml
    /// </summary>
    public partial class SubmitButton : UserControl
    {
        public SubmitButton()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(SubmitButton));

        public ICommand Command
        {
            get => (ICommand)GetValue(ButtonCommandProperty);
            set => SetValue(ButtonCommandProperty, value);
        }

        public static readonly DependencyProperty ButtonCommandProperty =
        DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(SubmitButton), new PropertyMetadata(null));
    }
}
