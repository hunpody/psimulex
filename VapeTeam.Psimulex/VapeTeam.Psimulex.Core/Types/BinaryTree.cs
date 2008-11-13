using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class BinaryTree : TreeBase
    {
        public BinaryTree Parent { get; private set; }

        public override TypeIdentifier Type
        {
            get
            {
                return TypeEnum.BinaryTree;
            }
        }

        public BinaryTree()
        {
        }

        public BinaryTree(BaseType value)
            : this()
        {
            this.Value = value;
        }

        public BinaryTree(Tree tree)
            : this(tree.Value)
        {
            if (tree.ChildrenCount >= 1)
            {
                Left = new BinaryTree(tree[0]);
            }
            if (tree.ChildrenCount >= 2)
            {
                Right = new BinaryTree(tree[1]);
            }
        }

        public BinaryTree Left
        {
            get;
            set;
        }

        public BinaryTree Right
        {
            get;
            set;
        }

        public override void Add(BaseType value)
        {
            if (Left == null)
            {
                Left = value.ToBinaryTree();
            }
            else if (Right == null)
            {
                Right = value.ToBinaryTree();
            }
            else
            {
                throw new Exceptions.PsimulexCoreException("The binary tree already has two children. You cannot add a third one.");
            }
        }

        public override void Assign(BaseType value)
        {
            BinaryTree otherBinTree = value.ToBinaryTree();
            this.Value = otherBinTree.Value;
            this.Left = otherBinTree.Left;
            this.Right = otherBinTree.Right;
        }


        protected BinaryTree CopyTree(BaseType value)
        {
            return value.ToBinaryTree().CopyReferenced();
        }

        /// <summary>
        /// Copies the tree but keeps the values of each node referenced. 
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        private BinaryTree CopyReferenced()
        {
            return new BinaryTree(BaseType.NullsafeReference(Value))
            {
                Left = Left ?? Left.CopyReferenced(),
                Right = Right ?? Right.CopyReferenced()
            };
        }

        public override BaseType Clone()
        {
            return new BinaryTree
            {
                // Should we set here the parent?
                Value = BaseType.NullsafeClone(Value),
                Left = BaseType.NullsafeClone(Left) as BinaryTree,
                Right = BaseType.NullsafeClone(Right) as BinaryTree
            };
        }

        protected override IEnumerable<TreeBase> GetChildren()
        {
            var children = new List<TreeBase>(2);
            if (Left != null)
                children.Add(Left);
            if (Right != null)
                children.Add(Right);
            return children;
        }

        public override string ToString()
        {
            if (Left == null && Right == null)
                return NullsafeToString(Value);
            return string.Format("{0} ({1}, {2})", NullsafeToString(Value), NullsafeToString(Left), NullsafeToString(Right));
        }

        public override BinaryTree ToBinaryTree() { return this; }
    
    }    //public class BinaryTree : Tree
    //{
    //    private class EmptyBinaryTree : BinaryTree { }

    //    public override TypeEnum TypeEnum
    //    {
    //        get
    //        {
    //            return TypeEnum.BinaryTree;
    //        }
    //    }

    //    public BinaryTree()
    //    {
    //    }

    //    public BinaryTree(BaseType value)
    //        : this()
    //    {
    //        this.Value = value;
    //        children.Add(null);
    //        children.Add(null);
    //    }

    //    public BinaryTree(Tree tree)
    //        : this(tree.Value)
    //    {
    //        for (int i=0; i<Math.Min(tree.ChildrenCount, 2); ++i)
    //            this.children.Add(new BinaryTree(tree[i]));
    //    }

    //    public BinaryTree Left
    //    {
    //        get
    //        {
    //            return children[0] as BinaryTree;
    //        }
    //        set
    //        {
    //            children[0] = value;
    //        }
    //    }

    //    public BinaryTree Right
    //    {
    //        get
    //        {
    //            return children[1] as BinaryTree;
    //        }
    //        set
    //        {
    //            children[1] = value;
    //        }
    //    }

    //    protected override Tree CopyTree(BaseType value)
    //    {
    //        return value.ToBinaryTree().CopyReferenced();
    //    }

    //    /// <summary>
    //    /// Copies the tree but keeps the values of each node referenced. 
    //    /// </summary>
    //    /// <param name="tree"></param>
    //    /// <returns></returns>
    //    public override Tree CopyReferenced()
    //    {
    //        return new BinaryTree(BaseType.NullsafeReference(Value))
    //        {
    //            // Parent?
    //            children = children.Select(child => {
    //                if (child == null)
    //                {
    //                    return null;
    //                }
    //                else
    //                {
    //                    return child.CopyReferenced();
    //                }
    //            }).ToList()
    //        };
    //    }

    //    public override void AddChild(BaseType value, int index)
    //    {
    //        if (children.Count(child => child != null) == 2)
    //        {
    //            throw new Exceptions.PsimulexCoreException("The binary tree already has two children. You cannot add a third one.");
    //        }
    //        if (index == -1)
    //        {
    //            index = children.FindIndex(child => child == null);
    //        }
    //        if (index < 0 || 2 <= index)
    //        {
    //            throw new Exceptions.InvalidOperationException("Cannot add child to the tree.",
    //                new Exceptions.IndexOutOfRangeException(index, 0, children.Count));
    //        }

    //        BinaryTree tree = CopyTree(value) as BinaryTree;
    //        tree.Parent = this;

    //        children[index] = tree;
    //    }

    //    public override BaseType Clone()
    //    {
    //        return new BinaryTree
    //        {
    //            // Should we set here the parent?
    //            Value = Value == null ? null : this.Value.Clone(),
    //            children = this.children.Select(child => BaseType.NullsafeClone(child) as Tree).ToList()
    //        };
    //    }

    //    public override BinaryTree ToBinaryTree() { return this; }
    //}
}
