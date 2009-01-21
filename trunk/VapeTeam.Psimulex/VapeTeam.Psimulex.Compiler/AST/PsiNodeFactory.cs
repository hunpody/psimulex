using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;

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
                case NodeType.MultiFunctionalProgram:
                    node = new MultiFuncionalProgramNode 
                    {
                        ProgramImports = children[0],
                        ProgramTypeDeclarations = children[1],
                        ProgramGlobalVariableDeclarations = children[2],
                        ProgramFunctionDeclarations = children[3]
                    }; v = true; break;
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

                /*Program Structures*/
                case NodeType.Block: node = new BlockNode(); v = true; break;
                case NodeType.Statement: node = new StatementNode(); v = true; break;
                case NodeType.IfStatement:
                    node = new IfStatementNode
                    {
                        IfBranch = children[0],
                        ElseIfBranchList = children.Count > 2 ? children.GetRange(1, children.Count - 2) : null,
                        ElseBranch = children.Count > 1 ? children[children.Count - 1] : null           
                    }; v = true; break;
                case NodeType.IfBranch: node = new IfBranchNode(); v = true; break;
                case NodeType.ElseIfBranches: node = new ElseIfBranchNode(); v = true; break;
                case NodeType.ConditionalBranch:
                    node = new ConditionalBranchNode
                    {
                        ConditionalBranchCondition = children[0],
                        ConditionalBranchCore = children[1]
                    }; v = true; break;
                case NodeType.ElseBranch: node = new ElseBranchNode(); v = true; break;
                case NodeType.DoStatement:
                    node = new DoStatementNode
                    {
                        DoCore = children[0],
                        DoCondition = children[1]
                    }; v = true; break;
                case NodeType.WhileStatement:
                    node = new WhileStatementNode
                    {
                        WhileCondition = children[0],
                        WhileCore = children[1]
                    }; v = true; break;
                case NodeType.PForStatement:
                    node = new PForStatementNode
                    {                         
                        PForInitialization = children[0],                        
                        PForCondition = children[1],
                        PForUpdate = children[2],
                        PForCore = children[3]
                    }; v = true; break;
                case NodeType.ForStatement:
                    node = new ForStatementNode
                    {
                        ForInitialization = children[0],
                        ForCondition = children[1],
                        ForUpdate = children[2],
                        ForCore = children[3]                     
                    }; v = true; break;
                case NodeType.ForInitialization: node = new ForInitializationNode(); v = true; break;
                case NodeType.ForCondition: node = new ForConditionNode(); v = true; break;
                case NodeType.ForUpdate: node = new ForUpdateNode(); v = true; break;
                case NodeType.PForEachStatement:
                    node = new PForEachStatementNode
                    {
                        PForEachIteratorType = children[0].Left,
                        PForEachIteratorName = children[0].Right,
                        PForEachInitialization = children[0],
                        PForEachCollectionExpression = children[1],
                        PForEachCore = children[2],                  
                    }; v = true; break;
                case NodeType.ForEachStatement:
                    node = new ForEachStatementNode
                    {
                        ForEachRunningVariableType = children[0].Left,
                        ForEachRunningVariableName = children[0].Right,                  
                        ForEachInitialization = children[0],
                        ForEachCollectionExpression = children[1],
                        ForEachCore = children[2],
                    }; v = true; break;
                case NodeType.ForEachInitialization: node = new ForEachInitializationNode(); v = true; break;
                case NodeType.ForEachCollectionExpression: node = new ForEachCollectionExpressionNode(); v = true; break;
                case NodeType.LoopStatement:
                    node= new LoopStatementNode
                    {
                        LoopIteratorInitialization = children[0],
                        LoopIteratorName = children[0].Left.Children[children[0].Left.Children.Count - 2],
                        LoopLimitExpression = children[1],
                        LoopCore = children[2]
                    }; v = true; break;
                case NodeType.LoopInitialization: node = new LoopInitializationNode(); v = true; break;
                case NodeType.LoopLimit: node = new LoopLimitNode(); v = true; break;
                case NodeType.Condition: node = new ConditionNode(); v = true; break;
                case NodeType.Core: node = new CoreNode(); v = true; break;
                case NodeType.PDoStatement: node = new PDoStatementNode(); v = true; break;
                case NodeType.AsynStatement: node = new AsynStatementNode(); v = true; break;
                case NodeType.LockStatement:
                    node = new LockStatementNode
                    {
                        LockVariableName = children[0],
                        LockCore = children[1]
                    }; v = true; break;
                case NodeType.ReturnStatement:
                    node = new ReturnStatementNode 
                    {
                        ReturnValue = children.Count == 2 ? children[1] : null
                    }; v = true; break;
                case NodeType.Return: node = new ReturnNode(); break;
                case NodeType.Break: node = new BreakNode(); break;
                //case NodeType.Continue: node = new ContinueNode(); break;
                case NodeType.ExpressionStatement: node = new ExpressionStatementNode(); v = true; break;
                case NodeType.VariableDeclarationStatement: node = new VariableDeclarationStatementNode(); v = true; break;
                case NodeType.VariableInitialization:
                    node = new VariableInitializationNode
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
                        MemberFunctionArgumentList = children[1].Children
                    }; v = true; break;
                case NodeType.FunctionCall:
                    node = new FunctionCallNode
                    {
                        FunctionName = children[0],
                        FunctionArgumentList = children[1].Children
                    }; v = true; break;
                case NodeType.Arguments: node = new ArgumentsNode(); v = true; break;
                case NodeType.Indexing: node = new IndexingNode(); v = true; break;
                case NodeType.ArrayInitializer:
                    node = new ArrayInitializatorNode
                    {
                        ArrayDataType = children[0],
                        ArrayDimensionList = children.GetRange(1,children.Count - 1)
                    }; v = true; break;
                case NodeType.CollectionInitializer:
                    node = new CollectionInitializatorNode
                    {
                        CollectionType = children[0],
                        CollectionElementList = children.GetRange(1, children.Count - 1)
                    }; v = true; break;

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
                case NodeType.DimensionMarker: node = new DimensionMarkerNode(); v = true; break;
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
                                  

            // NodeValueInfo Updateing
            if (!node.IsVirtual)
            {
                nodeValueInfo.StartLine = nodeValueInfo.Line;
                nodeValueInfo.StartColumn = nodeValueInfo.CharPositionInLine;

                nodeValueInfo.EndLine = nodeValueInfo.Line;
                nodeValueInfo.EndColumn = nodeValueInfo.StartColumn + value.Length;
            }
            else if (children.Count != 0 && node.IsVirtual)
            {
                // MaxKer, MinKer
                // MinStart, MaxStop

                Interval iv = new Interval { FromLine = -1, FromColumn = -1, ToLine = -1, ToColumn = -1 };
                PreOrderIntervalSearch(node, iv);
                
                nodeValueInfo.StartLine = iv.FromLine;
                nodeValueInfo.StartColumn = iv.FromColumn;

                nodeValueInfo.EndLine = iv.ToLine;
                nodeValueInfo.EndColumn = iv.ToColumn;
            }
            else 
            {
                nodeValueInfo.StartLine = -1;
                nodeValueInfo.StartColumn = -1;

                nodeValueInfo.EndLine = -1;
                nodeValueInfo.EndColumn = -1;
            }

            return node;
        }

        private void PreOrderIntervalSearch(IPsiNode node, Interval interval)
        {
            if (!node.IsVirtual)
            {
                // FirsTime Init
                if (interval.FromLine == -1 || interval.FromColumn == -1 || interval.ToLine == -1 || interval.ToColumn == -1)
                {
                    interval.FromLine = node.NodeValueInfo.StartLine;
                    interval.FromColumn = node.NodeValueInfo.StartColumn;
                    interval.ToLine = node.NodeValueInfo.EndLine;
                    interval.ToColumn = node.NodeValueInfo.EndColumn;
                }

                if (interval.FromLine >= node.NodeValueInfo.StartLine)
                {
                    if (interval.FromLine == node.NodeValueInfo.StartLine)
                    {
                        if (interval.FromColumn > node.NodeValueInfo.StartColumn)
                        {
                            interval.FromColumn = node.NodeValueInfo.StartColumn;
                        }
                    }
                    else
                    {
                        interval.FromColumn = node.NodeValueInfo.StartColumn;
                    }

                    interval.FromLine = node.NodeValueInfo.StartLine;
                }

                if (interval.ToLine <= node.NodeValueInfo.EndLine)
                {
                    if (interval.ToLine == node.NodeValueInfo.EndLine)
                    {
                        if (interval.ToColumn < node.NodeValueInfo.EndColumn)
                        {
                            interval.ToColumn = node.NodeValueInfo.EndColumn;
                        }
                    }
                    else
                    {
                        interval.ToColumn = node.NodeValueInfo.EndColumn;
                    }

                    interval.ToLine = node.NodeValueInfo.EndLine;
                }
            }

            foreach (var child in node.Children)
                PreOrderIntervalSearch ( child, interval );
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
