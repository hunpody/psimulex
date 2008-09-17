using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    /// <summary>
    /// PsiNode creator factory.
    /// </summary>
    public class PsiNodeFactory : IPsiNodeFactory
    {
        /// <summary>
        /// Create a tree node from some arguments.
        /// The function determines that, the node IS or IS NOT a Virtual node
        /// </summary>
        /// <param name="type">The type of the node</param>
        /// <param name="value">The value of the node</param>
        /// <param name="viewComment">The viewcomment is an user comment</param>
        /// <param name="parent">The parent of the node</param>
        /// <param name="children">The children of the node</param>
        /// <returns>The new node</returns>
        public IPsiNode CreateNode(NodeType type, string value,  string viewComment, IPsiNode parent, List<IPsiNode> children)
        {
            // Default nod is Non Virtual Node
            bool v = false;

            // If Not Implemented the Requied Switch Case (XNode)
            IPsiNode node = new XNode();

            switch (type)
            {
                /*Undefined*/
                case NodeType.X: node = new XNode(); break;

                /*High Level Node Types*/
                case NodeType.CompilationUnit: node = new CompilationUnitNode(); break;
                case NodeType.SimpleProgram: node = new SimpleProgramNode(); break;
                case NodeType.MultiFunctionalProgram: node = new MultiFuncionalProgramNode(); break;
                case NodeType.ImportDeclarations: node = new ImportDeclarationNode(); break;
                
                case NodeType.TypeDeclarations:
                    break;
                case NodeType.StructDeclaration:
                    break;
                case NodeType.GlobalVariableDeclarations:
                    break;
                case NodeType.MemberDeclaration:
                    break;
                case NodeType.FunctionDeclarations:
                    break;
                case NodeType.FunctionDeclaration:
                    break;
                case NodeType.FormalParameter:
                    break;
                case NodeType.Block:
                    break;
                case NodeType.VariableInitialisation:
                    break;
                case NodeType.VariableDeclaration:
                    break;
                case NodeType.AssignmentOp:
                    break;
                case NodeType.LogicalOrOp:
                    break;
                case NodeType.LogicalAndOp:
                    break;
                case NodeType.EqualityOp:
                    break;
                case NodeType.RelationOp:
                    break;
                case NodeType.AdditiveOp:
                    break;
                case NodeType.MultiplicativeOp:
                    break;
                case NodeType.UnaryOp:
                    break;
                case NodeType.Expression:
                    break;
                case NodeType.Assignment:
                    break;
                case NodeType.LambdaExpression:
                    break;
                case NodeType.LambdaParameter:
                    break;
                case NodeType.LambdaStatement:
                    break;
                case NodeType.MemberSelect:
                    break;
                case NodeType.MemberFunctionCall:
                    break;
                case NodeType.FunctionCall:
                    break;
                case NodeType.Indexing:
                    break;
                case NodeType.Dimensions:
                    break;
                case NodeType.DimensionMarker:
                    break;
                case NodeType.Identifier:
                    break;
                case NodeType.CharLiteral:
                    break;
                case NodeType.StringLiteral:
                    break;
                case NodeType.IntLiteral:
                    break;
                case NodeType.DecimalLiteral:
                    break;
                case NodeType.BoolLiteral:
                    break;
                case NodeType.NullLiteral:
                    break;
                case NodeType.InfinityLiteral:
                    break;
                case NodeType.DataTypeName:
                    break;
                case NodeType.DataType:
                    break;
                case NodeType.FunctionPointerType:
                    break;
                case NodeType.Type:
                    break;
                case NodeType.Reference:
                    break;

                default:
                    // If There Is Not The Requied Switch Case (XNode)
                    node = new XNode();
                    break;
            }
            
            // Init Datas in treeNode and Return
            node.Init(parent, value, type, v, viewComment);
            return node;
        }

        public IPsiNode CreateNode(NodeType type)
        {
            return CreateNode(type, "", "", null, null);
        }

        public IPsiNode CreateNode(NodeType type, string value)
        {
            return CreateNode(type, value, "", null, null);
        }
    }
}
