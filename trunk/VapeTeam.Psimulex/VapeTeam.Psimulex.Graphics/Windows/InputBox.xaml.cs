using System.Windows;

namespace VapeTeam.Psimulex.Graphics.Windows
{
    /// <summary>
    /// Interaction logic for InputBox.xaml
    /// </summary>
    public partial class InputBox : Window
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public string Value
        {
            get
            {
                return textBox1.Text;
            }
        }

        public string Caption
        {
            get
            {
                return label1.Content.ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    label1.Content = value;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
