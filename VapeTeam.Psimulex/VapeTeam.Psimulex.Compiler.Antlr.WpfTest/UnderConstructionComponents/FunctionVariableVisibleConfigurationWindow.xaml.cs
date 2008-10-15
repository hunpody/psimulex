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

using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Interaction logic for FunctionVariableVisibleConfigurationWindow.xaml
    /// </summary>
    public partial class FunctionVariableVisibleConfigurationWindow : Window
    {
        public string ConfigFilePath { get; set; }
        public IPsiNode PsiNode { get; set; }
        public PsiCodeGeneratorVisitor Visitor { get; set; }

        private FunctionVariableVisibleConfiguration config;

        public FunctionVariableVisibleConfigurationWindow()
        {
            InitializeComponent();
        }

        private void Init()
        {
            config = new FunctionVariableVisibleConfiguration(ConfigFilePath);
            var q = new PsiFunctionsVariablesQueryVisitor(Visitor.Source, Visitor.FileName);
            q.Visit(PsiNode as CompilationUnitNode);

            functionVariableTreeView.Items.Clear();
            q.PsiNodeList.ForEach(item => functionVariableTreeView.Items.Add(item.ToTreeView()));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }
    }
}
