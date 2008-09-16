using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VapeTeam.Psimulex.Compiler.Antlr.AST;




//////////////////// Ideiglenesen Van itt //////////////////
/* Jácótér :P */


namespace VapeTeam.Psimulex.Compiler
{
    using CommonTree = global::Antlr.Runtime.Tree.CommonTree;

    public class SzinténPsiASTException : Exception
    {
        public SzinténPsiASTException(string message)
            : base(message)
        {
        }

        public SzinténPsiASTException()
            : this("PsiASTException")
        {
        }
    }

    public class MárNemHasználtIdeiglenesenIttLevőPsiAST
    {
        public MárNemHasználtIdeiglenesenIttLevőPsiAST Parent { get; set; }
        public List<MárNemHasználtIdeiglenesenIttLevőPsiAST> Children { get; set; }

        /// <summary>
        /// Value is the Token text. ( Example: "+" , "import" , "for" , ... )
        /// Value == "" if the Nod is just virtual Node. ( Example: Type == Type.Function , Type.ForStatement , ... )
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Type is the Node type.
        /// </summary>
        public NodeType Type { get; set; }

        /// <summary>
        /// It is true if the Node is Virtual. (Don't have value)
        /// Can hold additional Informations.
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Comment to the dislpa. Example : ( NotImplemented, ... )
        /// </summary>
        public string ViewComment { get; set; }

        public MárNemHasználtIdeiglenesenIttLevőPsiAST()
        {
            Value = "";
            Type = NodeType.X;
            Children = new List<MárNemHasználtIdeiglenesenIttLevőPsiAST>();
        }

        #region MemberFunctions

        public MárNemHasználtIdeiglenesenIttLevőPsiAST(MárNemHasználtIdeiglenesenIttLevőPsiAST parent, string val, NodeType lab)
        {
            Parent = parent;
            Value = val;
            Type = lab;
            Children = new List<MárNemHasználtIdeiglenesenIttLevőPsiAST>();
        }

        public int ChildrenCount
        {
            get { return Children.Count; }
        }

        public MárNemHasználtIdeiglenesenIttLevőPsiAST Clone()
        {
            MárNemHasználtIdeiglenesenIttLevőPsiAST c = new MárNemHasználtIdeiglenesenIttLevőPsiAST(Parent, Value, Type);
            if (Children.Count != 0)
                foreach (MárNemHasználtIdeiglenesenIttLevőPsiAST t in Children)
                    c.Add(t.Clone());
            return c;
        }

        public void AddClone(MárNemHasználtIdeiglenesenIttLevőPsiAST child)
        {
            if (!Children.Contains(child))
            {
                MárNemHasználtIdeiglenesenIttLevőPsiAST c = child.Clone();
                c.Parent = this;
                Children.Add(c);
            }
        }

        public void Add(MárNemHasználtIdeiglenesenIttLevőPsiAST child)
        {
            if (!Children.Contains(child))
            {
                child.Parent = this;
                Children.Add(child);
            }
        }

        public void AddSibling(MárNemHasználtIdeiglenesenIttLevőPsiAST sibling)
        {
            if (Parent == null)
                throw new SzinténPsiASTException("Cannot add sibling to the root element of a tree, because root has no parent.");
            Parent.Add(sibling);
        }

        public MárNemHasználtIdeiglenesenIttLevőPsiAST GetFirstChild()
        {
            if (Children.Count > 0)
                return Children[0];
            return null;
        }

        public MárNemHasználtIdeiglenesenIttLevőPsiAST GetLastChild()
        {
            if (Children.Count > 0)
                return Children[Children.Count - 1];
            return null;
        }

        public MárNemHasználtIdeiglenesenIttLevőPsiAST GetNextSibling()
        {
            if (Parent != null)
            {
                int index = Parent.Children.IndexOf(this);
                if (index + 1 < Parent.Children.Count)
                    return Parent.Children[index + 1];
            }
            return null;
        }

        public override string ToString()
        {
            if (Value == null) Value = "NIL";
            return "(" + Type.ToString() + ") " + Value.ToString();
        }

        public TreeNode ToTreeNode(ViewMode vm)
        {
            return FromPsiASTToTreeNode(this, vm);
        }

        #endregion

        #region Static Functions

        public static MárNemHasználtIdeiglenesenIttLevőPsiAST FromCommonTreeToPsiAST(CommonTree tree)
        {
            MárNemHasználtIdeiglenesenIttLevőPsiAST root = null;
            if (tree != null)
            {
                // Itt megkell még határozni, hogy miylen típusú legyen. (Type.ASTLabel1)
                // Egy esetszétválasztás kell.
                // ...


                root = new MárNemHasználtIdeiglenesenIttLevőPsiAST(null, tree.Text, NodeType.X);


                if (tree.Children != null)
                    foreach (CommonTree child in tree.Children)
                        root.Add(FromCommonTreeToPsiAST(child));
            }
            return root;
        }

        public static TreeNode FromPsiASTToTreeNode(MárNemHasználtIdeiglenesenIttLevőPsiAST tree, ViewMode vm)
        {
            if (tree != null)
            {
                // ViewMode
                string text = "";
                switch (vm)
                {
                    case ViewMode.All:
                        text = tree.ToString();
                        break;
                    case ViewMode.Values:
                        text = tree.Value;
                        break;
                    case ViewMode.Hibrid:
                        if (tree.Value == "") text = tree.Type.ToString();
                        else text = tree.Value;
                        break;
                    default:
                        // Can't Be
                        break;
                }

                if (tree.Children != null)
                {
                    TreeNode[] children = new TreeNode[tree.Children.Count];

                    for (int i = 0; i < tree.Children.Count; i++)
                        children[i] = FromPsiASTToTreeNode(tree.Children[i], vm);
                    return new TreeNode(text, children);
                }
                return new TreeNode(text);
            }
            return new TreeNode("#");
        }

        #endregion
    }
}



    /*
    // Visitor Terv //

    public interface Visitor 
    {
        void Visit(PsiAST node);
        void VisitPsiAST(PsiAST tree);
    }

    // Ez a PsiAST nodokba kell
    public interface Node
    {
        void Accept(Visitor visitor);
    }
 
    class CompileVisitor : Visitor
    {
        public void Visit(PsiAST node)
        {
            // Switch NodeType alapján
            // Hogy illeszkedik ide a a rekurzív bejárás ...
        }
     
        public void VisitPsiAST(PsiAST tree)
        {
            // Fa bejárása
        }
    }
}



*/