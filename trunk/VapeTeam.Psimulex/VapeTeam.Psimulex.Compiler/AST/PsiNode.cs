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
    public class PsiNode : IPsiNode
    {
        #region IPsiNode Members

        public IPsiNode Parent { get; set; }
        public List<IPsiNode> Children { get; set; }

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
            Init(parent, new List<IPsiNode>(), value, type, false, "", nodeValueInfo);
        }

        public void Init(IPsiNode parent, List<IPsiNode> children, string value, NodeType type, bool isVirtual, string viewComment, NodeValueInfo nodeValueInfo)
        {
            Parent = parent;
            Children = children;
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
            if (i < ChildrenCount)
                return Children[i];
            else
                return null;
        }

        public IPsiNode Left
        {
            get
            {
                if (ChildrenCount > 0)
                    return Children[0];
                return null;
            }

            set
            {
                if (ChildrenCount > 0)
                    Children[0] = value;
                else
                    Add(value);
            }
        }

        public IPsiNode Right
        {
            get
            {
                if (Children.Count > 0)
                    return Children[Children.Count - 1];
                return null;
            }

            set
            {
                if (ChildrenCount > 0)
                    Children[Children.Count - 1] = value;
                else
                    Add(value);
            }
        }

        #endregion

        #region PsiNode Members

        public int ChildrenCount
        {
            get { return Children.Count; }
        }        

        public override string ToString()
        {
            if (Value == null || Value == "") throw new PsiNodeException("Value not initialised!");
            return "( " + Type.ToString() + " ) " + Value.ToString();
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
        public List<IPsiNode> StructMembers { get; set; }
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
    public class FunctionDeclarationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class FormalParameterNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class BlockNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }

    public class VariableInitialisationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class VariableDeclarationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
            
    /*Operators*/
    public class AssignmentOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LogicalOrOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LogicalAndOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class EqualityOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class RelationOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class AdditiveOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class MultiplicativeOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class UnaryOpNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
 
    /*Expressions*/
    public class ExpressionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class AssignmentNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    /*
    public class LambdaExpressionNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LambdaParameterNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class LambdaStatementNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    */

    public class MemberSelectNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class MemberFunctionCallNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
    public class FunctionCallNode : PsiNode { public override void Accept(IPsiVisitor v) { v.Visit(this); } }
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
