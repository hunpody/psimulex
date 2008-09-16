using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VapeTeam.Psimulex.Compiler.Antlr.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    public partial class frmTree : Form
    {
        public PsiNode PsiNode { get; set; }

        public frmTree()
        {
            InitializeComponent();
        }

        private void Init()
        {
            // AST -> TreeView
            treeView.Nodes.Add(TreeConverter.FromPsiNodeToTreeNode(PsiNode, ViewMode.All));
            treeView.SelectedNode = treeView.Nodes[0];
            treeView.ExpandAll();
            treeView.Nodes[0].EnsureVisible();

            // Collapse Import, Typedef, Global Variable Declaration sections
            if (treeView.Nodes[0].GetNodeCount(false) > 2)
            {
                treeView.Nodes[0].Nodes[0].Collapse();
                treeView.Nodes[0].Nodes[1].Collapse();
                treeView.Nodes[0].Nodes[2].Collapse();
            }
        }

        private void frmTree_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(TreeConverter.FromPsiNodeToTreeNode(PsiNode, ViewMode.All));
            treeView.SelectedNode = treeView.Nodes[0];
            treeView.ExpandAll();
        }

        private void valuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(TreeConverter.FromPsiNodeToTreeNode(PsiNode, ViewMode.Values));
            treeView.SelectedNode = treeView.Nodes[0];
            treeView.ExpandAll();
        }

        private void hibridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(TreeConverter.FromPsiNodeToTreeNode(PsiNode, ViewMode.Hibrid));
            treeView.SelectedNode = treeView.Nodes[0];
            treeView.ExpandAll();
        }
    }
}
