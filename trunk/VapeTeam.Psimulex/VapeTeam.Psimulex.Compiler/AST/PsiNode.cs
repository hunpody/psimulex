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

    #region Middle Class Type

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

        public void Init()
        {
            Init(null, "", NodeType.X, false, "");
        }

        public void Init(IPsiNode parent, string value, NodeType type)
        {
            Init(parent, value, type, false, "");
        }

        public void Init(IPsiNode parent, string value, NodeType type, bool isVirtual, string viewComment)
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
            v.Visit(this);
        }

        public IPsiNode Clone()
        {
            PsiNode c = new PsiNode();
            c.Init(Parent, Value, Type, IsVirtual, ViewComment);
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

        public IPsiNode First
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

        public IPsiNode Last
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
            if (Value == null || Value == "") throw new PsiNodeException("Value nut initialised!");
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
    // ...


    #endregion
}
