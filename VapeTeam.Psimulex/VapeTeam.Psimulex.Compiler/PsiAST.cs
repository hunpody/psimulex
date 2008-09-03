using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler
{
    public enum Type
    {
        ASTLabel1,
        ASTLabel2
    }

    public class PsiASTException : Exception
    {
        public PsiASTException(string message)
            : base(message)
        {
        }

        public PsiASTException()
            : this("PsiASTException")
        {
        }
    }

    public class PsiAST
    {
        public PsiAST Parent { get; set; }
        public List<PsiAST> Children { get; set; }

        /// <summary>
        /// Value is the Token text. ( Example: "+" , "import" , "for" , ... )
        /// Value == "" if the Nod is just virtual Node. ( Example: Type == Type.Function , Type.ForStatement , ... )
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Type is the Node type.
        /// </summary>
        public Type Type { get; set; }

        public PsiAST()
        {
            Children = new List<PsiAST>();
        }

        public PsiAST(PsiAST parent, string val, Type lab)
        {
            Parent = parent;
            Value = val;
            Type = lab;
        }

        public int ChildrenCount
        {
            get { return Children.Count; }
        }

        public PsiAST Clone()
        {
            PsiAST c = new PsiAST(Parent, Value, Type);
            if(Children.Count != 0)
                foreach (PsiAST t in Children)
                    c.Add(t.Clone());
            return c;
        }

        public void AddClone(PsiAST child)
        {
            if (!Children.Contains(child))
            {
                PsiAST c = child.Clone();
                c.Parent = this;
                Children.Add(c);
            }
        }

        public void Add(PsiAST child)
        {
            if (!Children.Contains(child))
            {
                child.Parent = this;
                Children.Add(child);
            }
        }

        public void AddSibling(PsiAST sibling)
        {
            if (Parent == null)
                throw new PsiASTException("Cannot add sibling to the root element of a tree, because root has no parent.");
            Parent.Add(sibling);
        }

        public PsiAST GetFirstChild()
        {
            if (Children.Count > 0)
                return Children[0];
            return null;
        }

        public PsiAST GetLastChild()
        {
            if (Children.Count > 0)
                return Children[Children.Count - 1];
            return null;
        }

        public PsiAST GetNextSibling()
        {
            if (Parent != null)
            {
                int index = Parent.Children.IndexOf(this);
                if (index + 1 < Parent.Children.Count)
                    return Parent.Children[index + 1];
            }
            return null;
        }
    }
}
