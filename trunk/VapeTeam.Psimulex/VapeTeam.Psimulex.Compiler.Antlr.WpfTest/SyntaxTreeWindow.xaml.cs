﻿using System;
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
    /// Interaction logic for SyntaxTreeWindow.xaml
    /// </summary>
    public partial class SyntaxTreeWindow : Window
    {        
        public string ConfigFilePath { get; set; }
        public IPsiNode PsiNode { get; set; }

        private List<NodeType> disabledNodeTypeList = new List<NodeType>();
        private SyntaxTreeConfiguration config = new SyntaxTreeConfiguration();
        private ViewMode currentViewMode;

        public SyntaxTreeWindow()
        {
            InitializeComponent();
        }

        public void Init()
        {
            // Reload Configuration
            ReloadConfiguration();       

            // Fill the TreeView with the Reduced PsiNode
            ShowExpressionTree(ViewMode.Hibrid);
        }

        private void ShowExpressionTree(ViewMode vm)
        {
            currentViewMode = vm;
            TreeView.Items.Clear();
            if (PsiNode != null)
            {
                PsiNode = PsiNode.Clone();
                List<IPsiNode> list = PsiNode.ReducePsiNode(disabledNodeTypeList);
                foreach (var child in list)
                    TreeView.Items.Add(child.ToWPFTreeViewItem(currentViewMode));
            }
        }

        private void ReloadConfiguration()
        {
            if (ConfigFilePath == null || ConfigFilePath == "")
                ConfigFilePath = "Default.cgf";
            config.Load(ConfigFilePath);

            // Query disabledNodeTypes
            disabledNodeTypeList.Clear();
            config.NodeTypeGroupList.ForEach(
                group => group.NodeTypeList.ForEach(
                    item =>
                    {
                        if (!item.Right)
                            disabledNodeTypeList.Add(item.Left);
                    }));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Hibrid_Click(object sender, RoutedEventArgs e)
        {
            ShowExpressionTree(ViewMode.Hibrid);
        }

        private void Value_Click(object sender, RoutedEventArgs e)
        {
            ShowExpressionTree(ViewMode.Values);
        }

        private void AllVisible_Click(object sender, RoutedEventArgs e)
        {
            ShowExpressionTree(ViewMode.All);
        }

        private void Everything_Click(object sender, RoutedEventArgs e)
        {
            ShowExpressionTree(ViewMode.Everything);
        }

        private void Interval_Click(object sender, RoutedEventArgs e)
        {
            ShowExpressionTree(ViewMode.Interval);
        }

        private void Configure_Click(object sender, RoutedEventArgs e)
        {
            SyntaxTreeConfigurationWindow stcw = new SyntaxTreeConfigurationWindow();
            stcw.ConfigFilePath = ConfigFilePath;
            stcw.ShowDialog();

            ReloadConfiguration();
            ShowExpressionTree(currentViewMode);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}