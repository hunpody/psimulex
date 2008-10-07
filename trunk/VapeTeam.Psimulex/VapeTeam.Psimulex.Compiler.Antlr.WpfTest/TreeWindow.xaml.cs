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
using VapeTeam.Psimulex.Compiler.AST;

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

        private void Everything_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
                TreeView.Items.Add(
                    VapeTeam.Psimulex.Compiler.AST.PsiNodeConverter.ToWPFTreeViewItem(
                        TesterForm.PsiNode, ViewMode.Everything));
        }

        private void AllVisible_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
                TreeView.Items.Add(
                    VapeTeam.Psimulex.Compiler.AST.PsiNodeConverter.ToWPFTreeViewItem(
                        TesterForm.PsiNode, ViewMode.All));
            
        }

        private void Hibrid_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
                TreeView.Items.Add(
                    VapeTeam.Psimulex.Compiler.AST.PsiNodeConverter.ToWPFTreeViewItem(
                        TesterForm.PsiNode, ViewMode.Hibrid));
            
        }

        private void Value_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
                TreeView.Items.Add(
                    TesterForm.PsiNode.ToWPFTreeViewItem(ViewMode.Values));
            
        }

        private void Interval_Click(object sender, RoutedEventArgs e)
        {
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
                TreeView.Items.Add(TesterForm.PsiNode.ToWPFTreeViewItem(ViewMode.Interval));
        }

        private void Reduce_Click(object sender, RoutedEventArgs e)
        {
            ReduceConfigWindow rcw = new ReduceConfigWindow();
            rcw.ShowDialog();
            /*
            TreeView.Items.Clear();
            if (TesterForm.PsiNode != null)
            {
                TreeView.Items.Add(
                    TesterForm.PsiNode.Clone()
                    .ReducePsiNode( new List<NodeType> { NodeType.CompilationUnit })
                    .ToWPFTreeViewItem(ViewMode.Hibrid));
            }*/
        }



        private void SearchVarAndFunc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var window = new SyntaxTreeWindow();

            if (TesterForm.PsiNode != null)
            {
                window.PsiNode = TesterForm.PsiNode;
                window.ConfigFilePath = "config.cgf";
                window.ShowDialog();
            }
            else
                MessageBox.Show("Először fordíts a Másik tesztprojektbe le vlamit, aztán tudod ezt megnézni.");



            /*SyntaxTreeConfiguration stc = new SyntaxTreeConfiguration();
            stc.Load("confi.cgf");
            stc.Save("confi.cgf");*/
        }




    }
}
