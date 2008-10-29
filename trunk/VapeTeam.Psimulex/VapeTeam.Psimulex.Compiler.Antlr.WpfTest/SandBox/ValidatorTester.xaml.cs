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
    /// Interaction logic for ValidatorTester.xaml
    /// </summary>
    public partial class ValidatorTester : Window
    {
        public ValidatorTester()
        {
            InitializeComponent();
        }

        private void intValidatorButton_Click(object sender, RoutedEventArgs e)
        {/*
            resultTextBox.Text += "Pattern: IntValidator Text: " + textTextBox.Text
            + " IsMatch: "
            + RegExpValidator.IsInt(textTextBox.Text).ToString();
            resultTextBox.Text += "\n";*/
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text += "Pattern: " + regexTextBox.Text + " Text: " + textTextBox.Text
            + " IsMatch: "
            + RegExpValidator.IsMatch(regexTextBox.Text, textTextBox.Text).ToString();
            resultTextBox.Text += "\n";
        }
    }
}
