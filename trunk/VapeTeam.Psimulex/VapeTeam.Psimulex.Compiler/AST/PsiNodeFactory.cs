using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
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
        public IPsiNode CreateNode(NodeType type, string value, NodeValueInfo nodeValueInfo, string viewComment, IPsiNode parent, List<IPsiNode> children)
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
                case NodeType.CompilationUnit: node = new CompilationUnitNode(); v = true; break;
                case NodeType.SimpleProgram: node = new SimpleProgramNode(); v = true; break;
                case NodeType.MultiFunctionalProgram: node = new MultiFuncionalProgramNode(); v = true; break;
                case NodeType.ImportDeclarations: node = new ImportDeclarationNode(); v = true; break;
                case NodeType.TypeDeclarations: node = new TypeDeclarationNode(); v = true; break;
                case NodeType.StructDeclaration: node = new StructDeclarationNode(); v = true;
                    (node as StructDeclarationNode).StructName = children[0];
                    (node as StructDeclarationNode).StructMembers = children.GetRange(1, children.Count - 1);
                    break;

                case NodeType.GlobalVariableDeclarations: node = new GlobalVariableDeclarationsNode(); v = true; break;
                case NodeType.MemberDeclaration: node = new MemberDeclarationNode(); v = true; break;
                case NodeType.FunctionDeclarations: node = new FunctionDeclarationsNode(); v = true; break;
                case NodeType.FunctionDeclaration: node = new FunctionDeclarationNode(); v = true; break;
                case NodeType.FormalParameter: node = new FormalParameterNode(); v = true; break;
                case NodeType.Block: node = new BlockNode(); v = true; break;

                case NodeType.VariableInitialisation: node = new VariableInitialisationNode(); v = true; break;
                case NodeType.VariableDeclaration: node = new VariableDeclarationNode(); v = true; break;

                /*Operators*/
                case NodeType.AssignmentOp: node = new AssignmentOpNode(); break;
                case NodeType.LogicalOrOp: node = new LogicalOrOpNode(); break;
                case NodeType.LogicalAndOp: node = new LogicalAndOpNode(); break;
                case NodeType.EqualityOp: node = new EqualityOpNode(); break;
                case NodeType.RelationOp: node = new RelationOpNode(); break;
                case NodeType.AdditiveOp: node = new AdditiveOpNode(); break;
                case NodeType.MultiplicativeOp: node = new MultiplicativeOpNode(); break;
                case NodeType.UnaryOp: node = new UnaryOpNode(); break;

                /*Expressions*/
                case NodeType.Expression: node = new ExpressionNode(); v = true; break;
                case NodeType.Assignment: node = new AssignmentNode(); v = true; break;
                /*
                case NodeType.LambdaExpression:
                    break;
                case NodeType.LambdaParameter:
                    break;
                case NodeType.LambdaStatement:
                    break;
                */

                case NodeType.MemberSelect: node = new MemberSelectNode(); v = true; break;
                case NodeType.MemberFunctionCall: node = new MemberFunctionCallNode(); v = true; break;
                case NodeType.FunctionCall: node = new FunctionCallNode(); v = true; break;
                case NodeType.Indexing: node = new IndexingNode(); v = true; break;
                case NodeType.Dimensions: node = new DimensionsNode(); v = true; break;
                case NodeType.ConstantDimensions: node = new ConstantDimensionsNode(); v = true; break;
                case NodeType.DimensionMarker: node = new DimensionMarkerNode(); v = true; break;

                /*Identifier*/
                case NodeType.Identifier: node = new IdentifierNode(); break;

                /*Literals*/
                case NodeType.CharLiteral: node = new CharLiteralNode();  break;
                case NodeType.StringLiteral: node = new StringLiteralNode(); break;
                case NodeType.IntLiteral: node = new IntLiteralNode(); break;
                case NodeType.DecimalLiteral: node = new DecimalLiteralNode(); break;
                case NodeType.BoolLiteral: node = new BoolLiteralNode(); break;
                case NodeType.NullLiteral: node = new NullLiteralNode(); break;
                case NodeType.InfinityLiteral: node = new InfinityLiteralNode(); break;

                /*Types*/
                case NodeType.DataTypeName: node = new DataTypeNameNode(); break;
                case NodeType.DataType: node = new DataTypeNode(); v = true; break;
                /*
                case NodeType.FunctionPointerType:
                    break;
                */
                case NodeType.Type: node = new TypeNode(); break;
                case NodeType.Reference: node = new ReferenceNode(); break;

                // If There Is Not The Requied Switch Case (XNode)
                default: node = new XNode(); break;
            }
            
            // Init Datas in treeNode and Return
            node.Init(parent, children, value, type, v, viewComment, nodeValueInfo);
            return node;
        }

        public IPsiNode CreateNode(NodeType type, string value, NodeValueInfo nodeValueInfo, List<IPsiNode> children)
        {
            return CreateNode(type, value, nodeValueInfo, "", null, children);
        }

        public IPsiNode CreateNode(NodeType type)
        {
            return CreateNode(type, "", new NodeValueInfo(), "", null, null);
        }

        public IPsiNode CreateNode(NodeType type, string value, NodeValueInfo nodeValueInfo)
        {
            return CreateNode(type, value, nodeValueInfo, "", null, null);
        }
    }
}
