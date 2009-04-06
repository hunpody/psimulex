using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace VapeTeam.Psimulex.Graphics.Windows
{
    /// <summary>
    /// Interaction logic for StandardOutputWindow.xaml
    /// </summary>
    public partial class StandardOutputWindow : Window
    {
        public StandardOutputWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        public new void AddText(string text)
        {
            outputTextBox.Text += text + "\n";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            thumb.DragDelta += new DragDeltaEventHandler(thumb_DragDelta);
        }

        void thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange);
            Canvas.SetTop(this, Canvas.GetTop(this) + e.VerticalChange);
        }

        public void ClearText()
        {
            outputTextBox.Text = string.Empty;
        }
    }
}
