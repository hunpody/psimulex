using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Controls;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// Display Modes
    /// </summary>
    public enum ViewMode
    {
        Everything,
        All,
        Values,
        Interval,
        Hibrid
    }

    /// <summary>
    /// It Converts PsiNode to Other Trees
    /// </summary>
    public static class PsiNodeConverter
    {
        /// <summary>
        /// Convert PsiNode tree to TreeNode tree. ( PsiNode -> WF TreeView )
        /// </summary>
        /// <param name="tree">Tree to convert</param>
        /// <param name="vm">Display Mode</param>
        /// <returns>TreeNode tree</returns>
        public static TreeNode ToWFTreeNode(this IPsiNode tree, ViewMode vm)
        {
            bool[] viewConfig = ToStringConfig(tree, vm);

            if (tree != null)
            {
                // ViewMode
                string text = tree.ToString(viewConfig[0], viewConfig[1], viewConfig[2]);

                if (tree.Children != null)
                {
                    TreeNode[] children = new TreeNode[tree.Children.Count];

                    for (int i = 0; i < tree.Children.Count; i++)
                        children[i] = ToWFTreeNode(tree.Children[i], vm);
                    return new TreeNode(text, children);
                }
                return new TreeNode(text);
            }
            return new TreeNode("#");
        }

        /// <summary>
        /// Convert PsiNode tree to TreeViewItem tree. ( PsiNode -> WPF TreeView )
        /// </summary>
        /// <param name="tree">Tree to convert</param>
        /// <param name="vm">Display Mode</param>
        /// <returns>TreeViewItem tree</returns>     
        public static TreeViewItem ToWPFTreeViewItem(this IPsiNode tree, ViewMode vm)
        {
            bool[] viewConfig = ToStringConfig(tree, vm);

            TreeViewItem twi = new TreeViewItem();
            twi.Header = "#";
            twi.IsExpanded = true;

            if (tree != null)
            {
                twi.Header = tree.ToString(viewConfig[0], viewConfig[1], viewConfig[2]);

                if (tree.Children != null)
                    tree.Children.ForEach(item => twi.Items.Add(ToWPFTreeViewItem(item, vm)));
            }
            return twi;
        }

        /// <summary>
        /// Convert ViewMode to ToStringConfiguration
        /// </summary>
        /// <param name="tree">Tree</param>
        /// <param name="vm">ViewMode</param>
        /// <returns></returns>
        private static bool[] ToStringConfig(IPsiNode tree, ViewMode vm)
        {
            bool[] config = new bool[3] { false, false, false };

            // ViewMode
            switch (vm)
            {
                case ViewMode.All: config = new bool[3] { true, true, false }; break;
                case ViewMode.Everything: config = new bool[3] { true, true, true }; break;
                case ViewMode.Values: config = new bool[3] { false, true, false }; break;
                case ViewMode.Interval: config = new bool[3] { false, false, true }; break;
                case ViewMode.Hibrid:
                    config = tree.IsVirtual ? new bool[3] { true, false, false } : new bool[3] { false, true, false };
                    break;
                default:
                    // Can't Be
                    break;
            }

            return config;
        }

        /// <summary>
        /// Reduce the PsiNode tree.
        /// It removes the specified types nodes.
        /// </summary>
        /// <param name="tree">The PsiNode to reduce</param>
        /// <param name="nodeTypeList">The list of types to remove</param>
        /// <returns>The reduced PsiNode</returns>
        public static List<IPsiNode> ReducePsiNode(this IPsiNode tree, List<NodeType> nodeTypeList)
        {
            return new List<IPsiNode>();
        }



        public static List<TreeViewItem> ToWPFTreeViewItemWithReduction(this IPsiNode tree, ViewMode vm, List<NodeType> nodeTypeList)
        {
            bool[] viewConfig = ToStringConfig(tree, vm);

            List<TreeViewItem> list = new List<TreeViewItem>();

            if (tree != null)
            {
                TreeViewItem twi;
                if (nodeTypeList.Contains(tree.Type))
                {
                    foreach (var child in tree.Children)
                    {
                        list.AddRange(ToWPFTreeViewItemWithReduction(child,vm,nodeTypeList));
                    }
                }
                else
                {
                    twi = new TreeViewItem();
                    twi.IsExpanded = true;
                    twi.Header = tree.ToString(viewConfig[0], viewConfig[1], viewConfig[2]);

                    foreach (var child in tree.Children)
                    {
                        foreach (var item in ToWPFTreeViewItemWithReduction(child, vm, nodeTypeList))
                        {
                            twi.Items.Add(item);
                        }                        
                    }

                    list.Add(twi);
                }
            }

            return list;
        }
    }
}
