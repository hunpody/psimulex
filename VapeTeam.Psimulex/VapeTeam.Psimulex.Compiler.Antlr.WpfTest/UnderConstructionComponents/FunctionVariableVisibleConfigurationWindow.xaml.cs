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
using System.Collections;

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
        private List<KeyValuePair<PsiFunctionsVariablesNode,CheckBox>> list;
        public List<PsiFunctionsVariablesNode> PsiFunctionsVariablesNodeList { get; set; }

        public FunctionVariableVisibleConfigurationWindow()
        {
            InitializeComponent();            
        }

        private void Init()
        {
            list = new List<KeyValuePair<PsiFunctionsVariablesNode, CheckBox>>();

            config = new FunctionVariableVisibleConfiguration(ConfigFilePath, PsiFunctionsVariablesNodeList);
            functionVariableTreeView.Items.Clear();
            config.PsiFunctionsVariablesNodeList.ForEach
                (
                    item => functionVariableTreeView.Items.Add(item.ToTreeView(list))
                );
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            list.ForEach(item => item.Key.IsMarked = (bool)item.Value.IsChecked);
            config.Save(ConfigFilePath);
        }
    }
}
