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
                case NodeType.StructDeclaration:
                    node = new StructDeclarationNode
                    {
                        StructName = children[0],
                        StructMemberList = children.GetRange(1, children.Count - 1)
                    }; v = true; break;
                case NodeType.GlobalVariableDeclarations: node = new GlobalVariableDeclarationsNode(); v = true; break;
                case NodeType.MemberDeclaration:
                    node = new MemberDeclarationNode
                    {
                        MemberType = children[0],
                        MemberTypeName = children[0].Left.Left,
                        MemberName = children[1],
                        MemberInitialValue = children.Count == 3 ? children[2] : null
                    }; v = true; break;
                case NodeType.FunctionDeclarations: node = new FunctionDeclarationsNode(); v = true; break;
                case NodeType.FunctionDeclaration:
                    node = new FunctionDeclarationNode
                    {
                        FunctionType = children[0],
                        FunctionReference = children.Count == 5 ? children[1] : null,
                        FunctionName = children[children.Count - 3],
                        FunctionParameterList = children[children.Count - 2],
                        FunctionBlock = children[children.Count - 1]
                    }; v = true; break;
                case NodeType.FormalParameterList: node = new FormalParameterListNode(); v = true; break;
                case NodeType.FormalParameter:
                    node = new FormalParameterNode
                    {
                        ParameterType = children[0],
                        ParameterReference = children.Count == 3 ? children[1] : null,
                        ParameterName = children[children.Count - 1]
                    }; v = true; break;
                case NodeType.Block: node = new BlockNode(); v = true; break;
                case NodeType.Statement: node = new StatementNode(); v = true; break;
                case NodeType.VariableInitialisation:
                    node = new VariableInitialisationNode
                    {
                        VariableType = children[0],
                        VariableReference = children.Count == 4 ? children[1] : null,
                        VariableName = children[children.Count - 2],
                        VariableInitialValue = children[children.Count - 1]
                    }; v = true; break;
                case NodeType.VariableDeclaration:
                    node = new VariableDeclarationNode
                    {
                        VariableType = children[0],
                        VariableName = children[1]
                    }; v = true; break;

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
                case NodeType.Cast: node = new CastNode();
                    node = new CastNode
                    {
                        CastTypeName = children[0].Left,
                        CastOperand = children[1]
                    }; v = true; break;
                case NodeType.PrefixUnaryOperation: node = new PrefixUnaryOperationNode(); v = true; break;
                /*
                case NodeType.LambdaExpression:
                    break;
                case NodeType.LambdaParameter:
                    break;
                case NodeType.LambdaStatement:
                    break;
                */

                case NodeType.Selector:
                    node = new SelectorNode
                    {
                        SelectorOperand = children[0],
                        SelectorList = children.GetRange(1, children.Count - 1)
                    }; v = true; break;
                case NodeType.MemberSelect: node = new MemberSelectNode(); v = true; break;
                case NodeType.MemberFunctionCall:
                    node = new MemberFunctionCallNode
                    {
                        MemberFunctionName = children[0],
                        MemberFunctionArgumentList = children.GetRange(1, children.Count - 1)
                    }; v = true; break;
                case NodeType.FunctionCall:
                    node = new FunctionCallNode
                    {
                        FunctionName = children[0],
                        FunctionArgumentList = children.GetRange(1, children.Count - 1)
                    }; v = true; break;
                case NodeType.Arguments: node = new ArgumentsNode(); v = true; break;
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
