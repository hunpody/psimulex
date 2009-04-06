using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Controls.Primitives;

namespace VapeTeam.Psimulex.Graphics.Windows
{
    /// <summary>
    /// Interaction logic for WatchWindow.xaml
    /// </summary>
    public partial class WatchWindow : Window
    {
        public WatchWindow()
        {
            InitializeComponent();
        }

        public void LoadVariable(VapeTeam.Psimulex.Core.Types.BaseType value, string name)
        {
            border.Child = Graphics.Factories.GraphicsElementFactory.Produce(value);
            titleLabel.Content = string.Format("{0} ({1} : {2})", titleLabel.Content, name, value.Type.TypeName);
            //value.Deleted += (o, e) => Close();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void thumb_DragDelta_1(object sender, DragDeltaEventArgs e)
        {

        }

        private bool iscollapsed = false;

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.ImeProcessedKey == Key.F11)
            //{
            //    iscollapsed = !iscollapsed;
            //}
            //border.Margin = new Thickness(4, 36, 8, iscollapsed ? 9 : 59);
            //label1.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            //label3.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            //slider1.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            //scaleSlider.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;    
        }

        private void thumb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (e.ImeProcessedKey == Key.F11)
            {
                iscollapsed = !iscollapsed;
            }
            border.Margin = new Thickness(4, 36, 8, iscollapsed ? 9 : 59);
            label1.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            label3.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            slider1.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            scaleSlider.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;
            closeButton.Visibility = iscollapsed ? Visibility.Hidden : Visibility.Visible;    
        }
    }
}
