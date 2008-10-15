using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// PsiNode Exception Class
    /// </summary>
    public class PsiNodeException : Exception
    {
        public PsiNodeException(string message)
            : base(message)
        {
        }

        public PsiNodeException()
            : this("PsiNodeException")
        {
        }
    }

    #region Middle Tree Node Type

    /// <summary>
    /// Common PsiAST Tree Node
    /// </summary>
    [Serializable]
    public class PsiNode : IPsiNode
    {
        #region IPsiNode Members

        public IPsiNode Parent { get; set; }
        public List<IPsiNode> Children { get; set; }
        public List<IPsiNode> Siblings
        {
            get
            {
                if (Parent != null)
                    return Parent.Children;
                else
                    return new List<IPsiNode>();
            } 
        }

        public NodeType Type { get; set; }
        public string Value { get; set; }
        public bool IsVirtual { get; set; }

        public string ViewComment { get; set; }

        public NodeValueInfo NodeValueInfo { get; set; }

        public void Init()
        {
            Init(null, new List<IPsiNode>(), "", NodeType.X, false, "", new NodeValueInfo());
        }

        public void Init(IPsiNode parent, string value, NodeType type, NodeValueInfo nodeValueInfo)
        {
            Init(parent, new List<IPsiNode>(), value, type, false, "", nodeValueInfo);
        }

        public void Init(IPsiNode parent, string value, NodeType type, bool isVirtual, string viewComment, NodeValueInfo nodeValueInfo)
        {
            Init(parent, new List<IPsiNode>(), value, type, isVirtual, "", nodeValueInfo);
        }

        public void Init(IPsiNode parent, List<IPsiNode> children, string value, NodeType type, bool isVirtual, string viewComment, NodeValueInfo nodeValueInfo)
        {
            Parent = parent;
            Children = children;
            foreach (IPsiNode child in Children)
                child.Parent = this;
            Value = value;
            Type = type;
            IsVirtual = isVirtual;
            ViewComment = viewComment;
            NodeValueInfo = nodeValueInfo;
        }

        public virtual void Accept(IPsiVisitor v)
        {
            v.Visit(this);
        }

        public IPsiNode Clone()
        {
            PsiNode c = new PsiNode();
            c.Init(Parent, Value, Type, IsVirtual, ViewComment, NodeValueInfo);
            if (Children.Count != 0)
                foreach (IPsiNode t in Children)
                    c.Add(t.Clone());
            return c;
        }

        public void Add(IPsiNode child)
        {
            if (!Children.Contains(child))
            {
                child.Parent = this;
                Children.Add(child);
            }
        }

        public IPsiNode GetChild(int i)
        {
            if (i < ChildrenCount) return Children[i];
            return null;
        }

        public IPsiNode Left
        {
            get
            {
                if (ChildrenCount > 0) return Children[0];
                return null;
            }

            set
            {
                if (ChildrenCount > 0) Children[0] = value;
                else Add(value);
            }
        }

        public IPsiNode Right
        {
            get
            {
                if (Children.Count > 0) return Children[Children.Count - 1];
                return null;
            }

            set
            {
                if (ChildrenCount > 0) Children[Children.Count - 1] = value;
                else Add(value);
            }
        }

        public IPsiNode BottomLeft
        {
            get
            {
                if (Left == null) return this;
                return Left.BottomLeft;
            }
        }

        public IPsiNode BottomRight
        {
            get
            {
                if (Right == null) return this;
                return Right.BottomRight;
            }
        }

        public string ToString(bool showType, bool showValue, bool showInterval)
        {
            string ret = "";
            string type = "( " + Type.ToString() + " ) ";
            string value = Value != null ? Value : "null";
            string interval = string.Format(" From:[ {0}, {1} ], To:[ {2}, {3} ]",
                            NodeValueInfo.StartLine, NodeValueInfo.StartColumn,
                            NodeValueInfo.EndLine, NodeValueInfo.EndColumn);

            if (showType) ret += type;
            if (showValue) ret += value;
            if (showInterval) ret += interval;

            return ret;
        }

        #endregion

        #region PsiNode Members

        public int ChildrenCount
        {
            get { return Children.Count; }
        }        

        public override string ToString()
        {
            return "( " + Type.ToString() + " ) " + ( Value != null ? Value : "null");
        }

        #endregion
    }

    #endregion

    #region Special Tree Node Types

    /*Undefined Tree Node*/
    public class XNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    /*High Level Tree Nodes*/
    public class CompilationUnitNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class SimpleProgramNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class MultiFuncionalProgramNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ImportDeclarationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class TypeDeclarationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class StructDeclarationNode : PsiNode 
    {
        public IPsiNode StructName { get; set; }
        public List<IPsiNode> StructMemberList { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class MemberDeclarationNode : PsiNode
    {
        public IPsiNode MemberType { get; set; }
        public IPsiNode MemberTypeName { get; set; }
        public IPsiNode MemberName { get; set; }
        public IPsiNode MemberInitialValue { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class GlobalVariableDeclarationsNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class FunctionDeclarationsNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class FunctionDeclarationNode : PsiNode
    {
        public IPsiNode FunctionType { get; set; }
        public IPsiNode FunctionReference { get; set; }
        public IPsiNode FunctionName { get; set; }
        public IPsiNode FunctionParameterList { get; set; }
        public IPsiNode FunctionBlock { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class FormalParameterListNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class FormalParameterNode : PsiNode
    {
        public IPsiNode ParameterType { get; set; }
        public IPsiNode ParameterReference { get; set; }
        public IPsiNode ParameterName { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    /*Program Structures*/
    public class BlockNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class StatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class IfStatementNode : PsiNode 
    {
        public IPsiNode IfBranch { get; set; }
        public List<IPsiNode> ElseIfBranchList { get; set; }
        public IPsiNode ElseBranch { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class IfBranchNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ElseIfBranchNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ConditionalBranchNode : PsiNode
    {
        public IPsiNode ConditionalBranchCondition { get; set; }
        public IPsiNode ConditionalBranchCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ElseBranchNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class DoStatementNode : PsiNode
    {
        public IPsiNode DoCore { get; set; }
        public IPsiNode DoCondition { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class WhileStatementNode : PsiNode
    {
        public IPsiNode WhileCondition { get; set; }
        public IPsiNode WhileCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class PForStatementNode : PsiNode
    {
        public IPsiNode PForInitialization { get; set; }
        public IPsiNode PForCondition { get; set; }
        public IPsiNode PForUpdate { get; set; }
        public IPsiNode PForCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ForStatementNode : PsiNode
    {
        public IPsiNode ForInitialization { get; set; }
        public IPsiNode ForCondition { get; set; }
        public IPsiNode ForUpdate { get; set; }
        public IPsiNode ForCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ForInitializationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ForConditionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ForUpdateNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class PForEachStatementNode : PsiNode
    {
        public IPsiNode PForEachIteratorType { get; set; }
        public IPsiNode PForEachIteratorName { get; set; }
        public IPsiNode PForEachInitialization { get; set; }
        public IPsiNode PForEachCollectionExpression { get; set; }
        public IPsiNode PForEachCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ForEachStatementNode : PsiNode
    {
        public IPsiNode ForEachRunningVariableType { get; set; }
        public IPsiNode ForEachRunningVariableName { get; set; }
        public IPsiNode ForEachInitialization { get; set; }
        public IPsiNode ForEachCollectionExpression { get; set; }
        public IPsiNode ForEachCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ForEachInitializationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ForEachCollectionExpressionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    public class LoopStatementNode : PsiNode
    {
        public IPsiNode LoopIteratorInitialization { get; set; }
        public IPsiNode LoopIteratorName { get; set; }
        public IPsiNode LoopLimitExpression { get; set; }
        public IPsiNode LoopCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class LoopInitializationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LoopLimitNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    public class ConditionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class CoreNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class PDoStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class AsynStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LockStatementNode : PsiNode
    {
        public IPsiNode LockVariableName { get; set; }
        public IPsiNode LockCore { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ReturnStatementNode : PsiNode
    {
        public IPsiNode ReturnValue { get; set; }

        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ReturnNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class BreakNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    //public class ContinueNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ExpressionStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    public class VariableDeclarationStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    public class VariableInitializationNode : PsiNode
    {
        public IPsiNode VariableType { get; set; }
        public IPsiNode VariableReference { get; set; }
        public IPsiNode VariableName { get; set; }
        public IPsiNode VariableInitialValue { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class VariableDeclarationNode : PsiNode
    {
        public IPsiNode VariableType { get; set; }
        public IPsiNode VariableReference { get; set; }
        public IPsiNode VariableName { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }
            
    /*Operators*/
    public class AssignmentOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LogicalOrOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LogicalAndOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class EqualityOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class RelationOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class AdditiveOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class MultiplicativeOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class UnaryOpNode : PsiNode
    {
        public IPsiNode UnaryOperand 
        {
            get
            {
                return Operand(this);
            }
        }

        private IPsiNode Operand(IPsiNode node)
        {
            if ((node.Right != null) && (node.Right.Type == NodeType.UnaryOp || node.Right.Type == NodeType.PrefixUnaryOperation))
                return Operand(node.Right);
            return node;
        }

        public override void Accept(IPsiVisitor v) { v.Visit(this); } 
    }
 
    /*Expressions*/
    public class ExpressionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class CastNode : PsiNode
    {
        public IPsiNode CastTypeName { get; set; }
        public IPsiNode CastOperand { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }
    public class PrefixUnaryOperationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    /*
    public class LambdaExpressionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LambdaParameterNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LambdaStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    */

    public class SelectorNode : PsiNode
    {
        public IPsiNode SelectorOperand { get; set; }
        public List<IPsiNode> SelectorList { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class MemberSelectNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class MemberFunctionCallNode : PsiNode
    {
        public IPsiNode MemberFunctionName { get; set; }
        public List<IPsiNode> MemberFunctionArgumentList { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class FunctionCallNode : PsiNode 
    {
        public IPsiNode FunctionName { get; set; }
        public List<IPsiNode> FunctionArgumentList { get; set; }
        public override void Accept(IPsiVisitor v) { v.Visit(this); }
    }

    public class ArgumentsNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class IndexingNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class DimensionsNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ConstantDimensionsNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class DimensionMarkerNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    /*ID*/
    public class IdentifierNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    /*Literals*/
    public class CharLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class StringLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class IntLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class DecimalLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class BoolLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class NullLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class InfinityLiteralNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    /*Types*/
    public class DataTypeNameNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class DataTypeNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    /*
    public class FunctionPointerTypeNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    */
    public class TypeNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class ReferenceNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    #endregion
}
