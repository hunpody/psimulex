using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.AntlrTools
{
    using CommonTree = global::Antlr.Runtime.Tree.CommonTree;

    public static class TreeConverter
    {
        private static NodeTypeFactory nodeTypeFactory = new NodeTypeFactory();
        private static PsiNodeFactory nodeFactory = new PsiNodeFactory();

        /// <summary>
        /// Convert ANTLR CommonTree to PsiNode tree. ( ANTLR AST -> PsiAST )
        /// </summary>
        /// <param name="tree">Tree to convert</param>
        /// <returns>PsiNode tree</returns>
        public static IPsiNode FromCommonTreeToPsiNode(this CommonTree tree)
        {
            IPsiNode root = null;
            NodeType type = NodeTypeFactory.CreateNodeType(tree.Type);

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
    }
}
