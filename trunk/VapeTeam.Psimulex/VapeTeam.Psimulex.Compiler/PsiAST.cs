using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler
{
    public enum Label
    {
        ASTLabel1,
        ASTLabel2
    }

    public class PsiASTException : Exception
    { }

    public class PsiAST
    {
        public PsiAST Parent { get; set; }
        public List<PsiAST> Children { get; set; }

        public string Value { get; set; }
        public Label Label { get; set; }

        public PsiAST()
        { }

        public PsiAST(PsiAST parent, string val, Label lab)
        {
            Parent = parent;
            Value = val;
            Label = lab;
        }

        public int ChildrenCount
        {
            get { return Children.Count; }
        }

        public PsiAST Clone()
        {
            PsiAST c = new PsiAST(Parent, Value, Label);
            if(Children != null)
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
        /*
        public void AddSibling(PsiAST sibling)
        {
            if (Parent == null)
                throw new TreeException("Cannot add sibling to the root element of a tree, because root has no parent.");
            Parent.Add(sibling);
        }

        public override void Assign(IValue v)
        {
            Tree rv = v.ToTree();
            Parent = rv.Parent;
            Children = rv.Children;
            Value = rv.Value;
        }

        public Tree GetFirstChild()
        {
            if (Children.Count > 0)
                return Children[0];

            return null;
        }
        public Tree GetLastChild()
        {
            if (Children.Count > 0)
                return Children[Children.Count - 1];
            return null;
        }

        public Tree GetNextSibling()
        {
            if (Parent != null)
            {
                int index = Parent.Children.IndexOf(this);
                if (index + 1 < Parent.Children.Count)
                    return Parent.Children[index + 1];
            }
            return null;
        }
         * */
    }
}
