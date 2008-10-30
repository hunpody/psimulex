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
    /// Interaction logic for CommonPrimaryInputBox.xaml
    /// </summary>
    public partial class CommonPrimaryInputBox : Window
    {
        public PrimaryInputValidator Validator { get; set; }
        public bool GenerateRandomValueOnStart { get; set; }

        public CommonPrimaryInputBox()
        {
            InitializeComponent();
        }

        private void randomizeButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Text = Validator.GenerateRandomInput();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Validate();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            inputTextBox.Focus();
        }

        private void Validate()
        {
            if (Validator.Validate(inputTextBox.Text))
                Close();
            else
                MessageBox.Show(Validator.ErrorMessage + "\n" + Validator.ExampleMessage, "Input Error!");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (GenerateRandomValueOnStart)
                inputTextBox.Text = Validator.GenerateRandomInput();
            else
                inputTextBox.Text = "";            

            enterLabel.Content = Validator.EnterMessage;
            exampleLabel.Content = Validator.ExampleMessage;
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange);
            Canvas.SetTop(this, Canvas.GetTop(this) + e.VerticalChange);
        }
    }
}
