using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
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


    /// <summary>
    /// Common AST Tree Node
    /// </summary>
    public class PsiNode : IPsiNode
    {
        public IPsiNode Parent { get; set; }
        public List<IPsiNode> Children { get; set; }

        public NodeType Type { get; set; }
        public string Value { get; set; }
        public bool IsVirtual { get; set; }

        public string ViewComment { get; set; }

        public PsiNode()
        {            
            Value = "";
            Type = NodeType.X;
            IsVirtual = false;
            ViewComment = "";
            Children = new List<IPsiNode>();
        }

        public PsiNode(IPsiNode parent, string value, NodeType type)
        {
            Parent = parent;
            Value = value;
            Type = type;
            IsVirtual = false;
            ViewComment = "";
            Children = new List<IPsiNode>();
        }

        public PsiNode(IPsiNode parent, string value, NodeType type, bool isVirtual, string viewComment)
        {
            Parent = parent;
            Value = value;
            Type = type;
            IsVirtual = isVirtual;
            ViewComment = viewComment;
            Children = new List<IPsiNode>();
        }

        public virtual void Accept(IPsiVisitor v)
        {
            v.VisitPsiNode(this);
        }

        public IPsiNode Clone()
        {
            PsiNode c = new PsiNode(Parent, Value, Type, IsVirtual, ViewComment);
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

        public override string ToString()
        {
            if (Value == null) Value = "NIL";
            return "(" + Type.ToString() + ") " + Value.ToString();
        }
    }

    #region Special Tree Nodes

    /*High Level Tree Nodes*/
    public class SimpleProgramNode : PsiNode { public override void Accept(IPsiVisitor v) { v.VisitSimpleProgramNode(this); } }
    public class MultiFuncionalProgramNode : PsiNode { public override void Accept(IPsiVisitor v) { v.VisitMultiFunctionalProgramNode(this); } }
    public class ImportDeclarationNode : PsiNode { public override void Accept(IPsiVisitor v) { v.VisitImportDeclarationNode(this); } }
    // ...


    #endregion
}
