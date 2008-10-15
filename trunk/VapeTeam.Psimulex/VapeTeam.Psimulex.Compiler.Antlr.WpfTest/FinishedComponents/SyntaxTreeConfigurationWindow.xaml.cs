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
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Antlr.Test;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    using CheckBoxPair = Pair<Pair<NodeType, bool>, CheckBox>;
    using CheckBoxPairList = List<Pair<Pair<NodeType, bool>, CheckBox>>;

    /// <summary>
    /// Interaction logic for SyntaxTreeConfigurationWindow.xaml
    /// </summary>
    public partial class SyntaxTreeConfigurationWindow : Window
    {
        public string ConfigFilePath { get; set; }

        private SyntaxTreeConfiguration config;
        private CheckBoxPairList checkBoxList;

        public SyntaxTreeConfigurationWindow()
        {            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            checkBoxList.ForEach(item => item.Left.Right = (bool)item.Right.IsChecked);
            config.Save(ConfigFilePath);
        }

        private void Init()
        {
            config = new SyntaxTreeConfiguration(ConfigFilePath);
            checkBoxList = new CheckBoxPairList();

            // Create Groupboxes and CheckBoxis //

            foreach (var group in config.NodeTypeGroupList)
            {
                GroupBox gb = new GroupBox();
                gb.Header = group.Name;

                StackPanel sp = new StackPanel();

                foreach (var visibleInfo in group.NodeTypeList)
                {
                    CheckBox cb = new CheckBox();
                    cb.Content = visibleInfo.Left;
                    cb.IsChecked = visibleInfo.Right;

                    sp.Children.Add(cb);
                    checkBoxList.Add(new CheckBoxPair { Left = visibleInfo, Right = cb });
                }

                gb.Content = sp;
                MainWrapPanel.Children.Add(gb);
            }
        }

        private void Restore_Click(object sender, RoutedEventArgs e)
        {
            checkBoxList.ForEach(item => item.Right.IsChecked = item.Left.Right);
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            checkBoxList.ForEach(item => item.Right.IsChecked = true);
        }

        private void UnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            checkBoxList.ForEach(item => item.Right.IsChecked = false);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
