using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Tree : TreeBase
    {        
        #region Custom collections for children

        /// <summary>
        /// Returns the children collection in a Psimulex-friendly format
        /// </summary>
        public class TreeNodeCollection : List
        {
            private Tree tree;

            public TreeNodeCollection(Tree tree)
            {
                this.tree = tree;
            }

            public override BaseType Index(int index, ICommandContext context)
            {
                return tree.children[index];
            }

            public override int Size
            {
                get
                {
                    return tree.children.Count;
                }
            }

            public override void Add(BaseType value)
            {
                tree.children.Add(value.ToTree());
                tree.OnChanged();
            }

            public override void Clear()
            {
                tree.children.Clear();
                tree.OnChanged();
            }

            public override IEnumerable<BaseType> AsEnumerable()
            {
                return tree.children.Cast<BaseType>();
            }

            public override void Insert(BaseType value)
            {
                tree.children.Add(value.ToTree());
                tree.OnChanged();
            }
        }

        #endregion

        #region Public properties

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Tree; }
        }

        public List Children
        {
            get
            {
                return new TreeNodeCollection(this);
            }
        }

        public Tree this[int index]
        {
            get
            {
                return children[index];
            }
        }

        protected List<Tree> children;

        public Tree Parent { get; set; }

        #endregion

        public Tree()
        {
            children = new List<Tree>();
        }

        /// <summary>
        /// Constructs a tree with a predefined value in its root.
        /// </summary>
        /// <param name="value"></param>
        public Tree(BaseType value)
            : this()
        {
            Value = value;
        }

        /// <summary>
        /// Constructs a tree from a collection. The root element will be null, and every element of the collection will be the child of the root.
        /// </summary>
        /// <param name="collection"></param>
        public Tree(IEnumerable<BaseType> collection)
            : this()
        {
            children.AddRange(collection.Select(item => new Tree { Parent = this, Value = item }));
        }

        protected override IEnumerable<TreeBase> GetChildren()
        {
            return children.Cast<TreeBase>();
        }

        #region Operators

        public override void Add(BaseType value)
        {
            AddChild(value, -1);
        }

        protected virtual Tree CopyTree(BaseType value)
        {
            return value.ToTree().CopyReferenced();
        }

        public virtual void AddChild(BaseType value, int index)
        {
            Tree childTree = CopyTree(value);
            childTree.Parent = this;

            if (index == -1)
            {
                index = children.Count;
            }

            if (index < 0 || index > children.Count)
            {
                throw new Exceptions.InvalidOperationException("Cannot add child to the tree.",
                    new Exceptions.IndexOutOfRangeException(index, 0, children.Count));
            }

            children.Insert(index, childTree);
            OnChanged();
        }

        public override void Assign(BaseType value)
        {
            var otherTree = value.ToTree();
            Parent = otherTree.Parent;
            Value = otherTree.Value;
            children = otherTree.children;
            OnChanged();
        }

        public override BaseType Clone()
        {
            return new Tree
            {
                // Should we set here the parent?
                Value = Value == null ? null : this.Value.Clone(),
                children = this.children.Select(child => child.Clone() as Tree).ToList()
            };
        }
    
        /// <summary>
        /// Copies the tree but keeps the values of each node referenced. 
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public virtual Tree CopyReferenced()
        {
            return new Tree
            {
                // Parent?
                Value = BaseType.NullsafeReference(Value),
                children = children.Select(child => child.CopyReferenced()).ToList()
            };
        }

        private Tree GetNextSibling(int position)
        {
            if (this.Parent == null)
            {
                throw new Exceptions.InvalidOperationException(string.Format("Can't get next sibling because the tree has no parent."));
            }
            int siblingIndex = Parent.children.IndexOf(this);
            if (Parent.children.Count <= siblingIndex + position)
            {
                throw new Exceptions.InvalidOperationException(string.Format("Can't get next sibling because this tree is the last child of its parent."));
            }
            if (siblingIndex + position < 0)
            {
                throw new Exceptions.InvalidOperationException(string.Format("Can't get previous sibling because this tree is the first child of its parent."));
            }

            return Parent.children[siblingIndex + position];
        }

        /// <summary>
        /// The next child of its parent.
        /// </summary>
        public Tree NextSibling
        {
            get
            {
                return GetNextSibling(1);
            }
        }

        /// <summary>
        /// The previous child of its parent.
        /// </summary>
        public Tree PreviousSibling
        {
            get
            {
                return GetNextSibling(-1);
            }
        }

        #endregion

        public override string ToString()
        {
            string valueString = NullsafeToString(Value);
            if (children.Count == 0)
                return valueString;
            else
                return string.Format("{0} ({1})", valueString, string.Join(", ", children.Select(child => child.ToString()).ToArray()));
        }

        public override Tree ToTree()
        {
            return this;
        }

        public override BinaryTree ToBinaryTree()
        {
            return new BinaryTree(this);
        }
    }
}
