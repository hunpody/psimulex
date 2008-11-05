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
    /// Interaction logic for CommonCollectionInputBox.xaml
    /// </summary>
    public partial class CommonCollectionInputBox : Window
    {
        public InputType InputType { get; set; }

        public CommonCollectionInputBox()
        {
            InitializeComponent();
            InputType = InputType.CommaSeparated;
        }

        private void Init()
        {
            ChangeInput(InputType);
        }

        private void ChangeInput(InputType type)
        {
            switch (InputType)
            {
                case InputType.CommaSeparated:
                    //mainBorder.Child = new TextBox();
                    break;
                case InputType.EndLineSeparated:
                    break;
                case InputType.Table:
                    break;
                case InputType.List:
                    break;
                default:
                    break;
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void randomizeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }
    }
}
