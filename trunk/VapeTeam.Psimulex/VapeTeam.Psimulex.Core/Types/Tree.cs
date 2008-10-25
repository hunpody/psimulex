using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Tree : BaseType
    {        
        #region Custom collections for children

        public class TreeNodeCollection : List
        {
            private Tree tree;
            public TreeNodeCollection(Tree tree)
            {
                this.tree = tree;
            }

            public override BaseType Index(int index)
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
            }

            public override void Clear()
            {
                tree.children.Clear();
            }

            public override IEnumerable<BaseType> GetAsEnumerable()
            {
                return tree.children.Cast<BaseType>();
            }

            public override void Insert(BaseType value)
            {
                tree.children.Add(value.ToTree());
            }
        }

        #endregion

        #region Public properties

        public override TypeEnum TypeEnum
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

        private List<Tree> children;

        /// <summary>
        /// The value being stored inside the tree.
        /// </summary>
        public BaseType Value { get; set; }

        public Tree Parent { get; private set; }

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

        #region Operators

        public override void Add(BaseType value)
        {
            Tree childTree = value.ToTree();
            childTree.Parent = this;
            children.Add(childTree);
        }

        public override void Assign(BaseType value)
        {
            var otherTree = value.ToTree();
            Parent = otherTree.Parent;
            Value = otherTree.Value;
            children = otherTree.children;
        }

        public override BaseType Clone()
        {
            return new Tree
            {
                // Should we set here the parent?
                Value = this.Value.Clone(),
                children = this.children.Select(child => child.Clone() as Tree).ToList()
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
            // PostOrder

            string valueString = "null";
            if (Value != null)
            {
                valueString = Value.ToString();
            }

            if (children.Count == 0)
                return valueString;
            else
                return string.Format("{0} ({1})", valueString, string.Join(", ", children.Select(child => child.ToString()).ToArray()));
        }

        //#region Represenation

        //#endregion

        //#region Constructors

        //public Tree()
        //{
        //    Children = new List<Tree>();
        //}

        //public Tree(BaseType value)
        //    :this()
        //{
        //    Value = value.Clone();
        //}
        
        //public Tree(BaseTypeList rep)
        //    :this(rep[0])
        //{
        //    rep.GetRange(1, Count - 1).ForEach(val => Children.Add(new Tree(val)));
        //}

        //#endregion

        //#region Own Members

        //public Tree Parent { get; set; }
        //public BaseType Value { get; set; }
        //public List<Tree> Children { get; set; }

        ///*
        //public BaseType EdgeToParentValue { get; set; }

        //public string EdgeToParentColor { get; set; }
        //public string Color { get; set; }
        //*/

        //public Tree FirstChild { get { return Left; } }
        //public Tree Left
        //{
        //    get { return ChildrenCount != 0 ? Children[0] : null; }
        //    set 
        //    {
        //        if (ChildrenCount != 0)
        //            Children[0] = value;
        //        else
        //            Children.Add(value); 
        //    }
        //}

        //public Tree LastChild { get { return Right; } }
        //public Tree Right
        //{
        //    get { return ChildrenCount != 0 ? Children[Children.Count - 1] : null; }
        //    set
        //    {
        //        if (ChildrenCount != 0)
        //            Children[Children.Count - 1] = value;
        //        else
        //            Children.Add(value);  
        //    }
        //}

        //public int ChildrenCount { get { return Children.Count; } }

        //public void AddChild(Tree value) { Insert(value); }
        //public void Insert(Tree value)
        //{
        //    Children.Add(value);
        //}

        //public void AddSibling(Tree value)
        //{
        //    if (Parent == null)
        //        throw new Exceptions.PsimulexCoreException("Can not add sibling to the root element of a tree, because root has no parent.");
        //    Parent.AddChild(value);
        //}

        //public Tree GetChild(int index)
        //{
        //    if (0 <= index && index <= Children.Count - 1)
        //        return Children[index];
        //    else
        //        throw new Exceptions.IndexOutOfRangeException(index, 0, Children.Count - 1);
        //}

        //public Tree GetNextSibling()
        //{
        //    if (Parent == null)
        //    {
        //        throw new Exceptions.PsimulexCoreException("Can not get sibling of the root element of a tree, because root has no parent.");
        //    }
        //    else
        //    {
        //        int index = Parent.Children.IndexOf(this);
        //        if (index + 1 < Parent.Children.Count)
        //            return Parent.Children[index + 1];
        //    }
        //    return null;
        //}

        //public Tree DeleteLastChild() { return Remove(); }
        //public Tree RemoveLastChild() { return Remove(); }
        //public Tree Remove()
        //{
        //    Tree ret = null;
        //    if (Children.Count != 0)
        //    {
        //        ret = Children.Last<Tree>();
        //        Children.RemoveAt(Children.Count - 1);
        //    }
        //    return ret;
        //}

        //public Tree DeleteFirstChild() { return RemoveFirstChild(); }
        //public Tree RemoveFirstChild()
        //{
        //    Tree ret = null;
        //    if (Children.Count != 0)
        //    {
        //        ret = Children[0];
        //        Children.RemoveAt(0);
        //    }
        //    return ret;
        //}

        //#endregion

        //#region Implemented Members

        //public override TypeEnum TypeEnum { get { return TypeEnum.Tree; } }
        //public override System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable()
        //{
        //    return null;
        //    //return ToPostOrderList();
        //}

        //private BaseTypeList ToPostOrderList()
        //{
        //    var btl = new BaseTypeList();
        //    if (Value != null)
        //        btl.Add(Value);
        //    Children.ForEach(child => btl.AddRange(child.ToPostOrderList()));
        //    return btl;
        //}

        //// Preorder,Inorder,Szintfolytonos ( Propertivel lehetne állítani, hogy írja ki, hogy járja be )

        //public override BaseType Index(int index)
        //{
        //    return GetChild(index);
        //}

        //public override int Size { get { return ToPostOrderList().Count; } }

        //public override BaseType Clone()
        //{
        //    BaseTypeList btl = ToPostOrderList();
        //    if (btl.Count != 0)
        //        return new Tree(btl);
        //    else
        //        return new Tree();
        //}

        //#endregion

        //#region Relational comparison operators

        //public override bool EqualsTo(BaseType value)
        //{
        //    return ToPostOrderList().IsEqualTo(value.ToTree().ToPostOrderList());
        //}

        //#endregion

        //#region Operator Members

        //public override void Assign(BaseType value)
        //{
        //    Value = value.ToTree().Value.Clone();
        //    Children.Clear();
        //    value.ToTree().Children.ForEach(child => Children.Add(child.Clone().ToTree()));
        //}

        //public override void Add(BaseType value) 
        //{
        //    Children.Add(value.Clone().ToTree());
        //}

        //#endregion

        //#region Conversion To Primitive Type Members

        //public override string ToString()
        //{
        //    // PostOrderToString
        //    string str = "";
        //    if(Value != null)
        //        str = Value.ToString();            
        //    str += "( ";
        //    for( int i = 0; i < ChildrenCount; i++ )
        //    {
        //        str += "( " + Children.ToString() + " )";
        //        if (i != ChildrenCount - 1)
        //            str += ", ";
        //    }
        //    str += " )";
        //    return str;                
        //}
                
        //#endregion

        //#region Conversion To BuiltIn Type Members

        //public override Array ToArray() { return new Array(ToPostOrderList()); }
        //public override List ToList() { return new List(ToPostOrderList()); }
        //public override Set ToSet() { return new Set(ToPostOrderList()); }
        //public override Stack ToStack() { return new Stack(ToPostOrderList()); }
        //public override Queue ToQueue() { return new Queue(ToPostOrderList()); }
        //public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(ToPostOrderList()); }

        ////public override LinkedList ToLinkedList() { throw new PsimulexCoreException("Invalid operation"); }
        ////public override Graph ToGraph() { throw new PsimulexCoreException("Invalid operation"); }
        ////public override GraphEdge ToGraphEdge() { throw new PsimulexCoreException("Invalid operation"); }
        ////public override GraphNode ToGraphNode() { throw new PsimulexCoreException("Invalid operation"); }
        //public override Tree ToTree() { return this; }
        ////public override BinaryTree ToBinaryTree() { throw new PsimulexCoreException("Invalid operation"); }

        //#endregion
        
    }
}
