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

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    /// <summary>
    /// Interaction logic for YesNoInputBox.xaml
    /// </summary>
    public partial class YesNoInputBox : Window
    {
        public bool Answer { get; set; }
        public string Question { get; set; }

        public YesNoInputBox()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Question != string.Empty)
                Title = Question;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            Answer = true;
            Close();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            Answer = false;
            Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            yesButton.Focus();
        }
    }
}
