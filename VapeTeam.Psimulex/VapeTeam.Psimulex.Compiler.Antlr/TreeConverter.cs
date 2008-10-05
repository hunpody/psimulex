using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr
{
    using CommonTree = global::Antlr.Runtime.Tree.CommonTree;

    public enum ViewMode
    {
        All,
        Values,
        Hibrid
    }

    public class TreeConverter
    {
        private static NodeTypeFactory nodeTypeFactory = new NodeTypeFactory();
        private static PsiNodeFactory nodeFactory = new PsiNodeFactory();

        /// <summary>
        /// Convert ANTLR CommonTree to PsiNode tree. ( ANTLR AST -> PsiAST )
        /// </summary>
        /// <param name="tree">Tree to convert</param>
        /// <returns>PsiNode tree</returns>
        public static IPsiNode FromCommonTreeToPsiNode(CommonTree tree)
        {
            IPsiNode root = null;
            NodeType type = nodeTypeFactory.CreateNodeType(tree.Type);

            string value = tree.Text;
            if (type == NodeType.X)
                value = value + " # TypeID [" + tree.Type + "]";

            if (tree != null)
            {
                List<IPsiNode> children = new List<IPsiNode>();
                if (tree.Children != null)
                {    
                    foreach (CommonTree antlrChild in tree.Children)
                    {
                        IPsiNode psiChild = FromCommonTreeToPsiNode(antlrChild);
                        if (psiChild != null)
                            children.Add(psiChild);
                    }
                }

                root = nodeFactory.CreateNode
                            (
                                type, value,
                                new NodeValueInfo ( tree.CharPositionInLine, tree.Line),
                                "",
                                null,
                                children
                            );
            }
            return root;
        }

        /// <summary>
        /// Convert PsiNode tree to TreeNode tree. ( PsiNode -> TreeView )
        /// </summary>
        /// <param name="tree">Tree to convert</param>
        /// <param name="vm">Display View Mode</param>
        /// <returns>TreeNode tree</returns>
        public static TreeNode FromPsiNodeToTreeNode(IPsiNode tree, ViewMode vm)
        {
            if (tree != null)
            {
                // ViewMode
                string text = "";
                switch (vm)
                {
                    case ViewMode.All:
                        //text = tree.ToString();
                        text = tree.ToString() + string.Format(" From:[ {0}, {1} ],To:[ {2}, {3} ])",
                            tree.NodeValueInfo.StartLine, tree.NodeValueInfo.StartColumn,
                            tree.NodeValueInfo.EndLine, tree.NodeValueInfo.EndColumn);
                        break;
                    case ViewMode.Values:
                        text = tree.Value;
                        break;
                    case ViewMode.Hibrid:
                        if (tree.IsVirtual) text = "(" + tree.Type.ToString() + ")";
                        else text = tree.Value;
                        break;
                    default:
                        // Can't Be
                        break;
                }

                if (tree.Children != null)
                {
                    TreeNode[] children = new TreeNode[tree.Children.Count];

                    for (int i = 0; i < tree.Children.Count; i++)
                        children[i] = FromPsiNodeToTreeNode(tree.Children[i], vm);
                    return new TreeNode(text, children);
                }
                return new TreeNode(text);
            }
            return new TreeNode("#");
        }
    }
}
