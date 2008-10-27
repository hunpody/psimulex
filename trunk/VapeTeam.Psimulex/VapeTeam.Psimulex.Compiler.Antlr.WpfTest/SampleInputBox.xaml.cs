using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Interaction logic for SampleInputBox.xaml
    /// </summary>
    public partial class SampleInputBox : Window
    {
        public SampleInputBox()
        {
            InitializeComponent();
        }

        public string EnteredText
        {
            get
            {
                return inputTextBox.Text;
            }
        }

        private void okayButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange);
            Canvas.SetTop(this, Canvas.GetTop(this) + e.VerticalChange);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            inputTextBox.Focus();
        }
    }
}
