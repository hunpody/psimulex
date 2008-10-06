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
using System.Windows.Forms.Integration;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Antlr.Test;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Interaction logic for TreeWindow.xaml
    /// </summary>
    public partial class TreeWindow : Window
    {
        public TesterForm TesterForm { get; set; }

        public TreeWindow()
        {
            InitializeComponent();
            
            TesterForm = new TesterForm();
            TesterForm.Show();            
        }

        private void AllVisible_Click(object sender, RoutedEventArgs e)
        {
            var twi = new TreeViewItem();
            var twi1 = new TreeViewItem();
            var twi2 = new TreeViewItem();

            var cb = new CheckBox();
            cb.Content = "Egy";
            twi.Header = cb;

            var cb1 = new CheckBox();
            cb1.Content = "Child1";
            twi1.Header = cb1;

            var cb2 = new CheckBox();
            cb2.Content = "Child2";
            twi2.Header = cb2;

            TreeView.Items.Add(twi);
            (TreeView.Items[0] as TreeViewItem).Items.Add(twi1);
            (TreeView.Items[0] as TreeViewItem).Items.Add(twi2);
        }

        private void Hibrid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Value_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reduce_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchVarAndFunc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
