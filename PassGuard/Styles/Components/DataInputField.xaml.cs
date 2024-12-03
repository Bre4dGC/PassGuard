using System.Windows;
using System.Windows.Controls;

namespace PassGuard.Styles.Components
{
    /// <summary>
    /// Логика взаимодействия для DataInputField.xaml
    /// </summary>
    public partial class DataInputField : UserControl
    {
        public DataInputField()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(DataInputField), new PropertyMetadata(string.Empty, OnTextChanged));

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataInputField control)
            {
                control.OnTextChanged(e);
            }
        }

        private void OnTextChanged(DependencyPropertyChangedEventArgs e)
        {
            TextBox.Text = Text;
        }
    }
}
