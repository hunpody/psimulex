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

        private void button2_Click(object sender, RoutedEventArgs e)
        {   /*
            var w = new FunctionVariableVisibleConfigurationWindow();
            w.ShowDialog();
            */
            var q = new PsiFunctionsVariablesQueryVisitor(TesterForm.visitor.Source,TesterForm.visitor.FileName);

            q.Visit(TesterForm.PsiNode as CompilationUnitNode);

            TreeView.Items.Clear();
            q.PsiNodeList.ForEach(item => TreeView.Items.Add(item.ToTreeView()));
        }




    }
}
