using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class BinaryTree : AbstractCollection    // Tree
    {
        #region Represenation

        #endregion

        #region Constructors

        public BinaryTree()
        {
        }

        public BinaryTree(BaseType value)
            :this()
        {
            Value = value.Clone();
        }

        /*
        public BinaryTree(BaseTypeList rep)
            :this(rep[0])
        {
            // Build a BinTree From a List
        }
        */

        #endregion

        #region Own Members

        public BinaryTree Parent { get; set; }

        public BaseType Value { get; set; }

        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        /*
        public BaseType EdgeToParentValue { get; set; }

        public string EdgeToParentColor { get; set; }
        public string Color { get; set; }
        */

        public int ChildrenCount
        {
            get
            {
                if (Left == null && Right == null)
                    return 2;
                else if (Left == null || Right == null)
                    return 1;
                else
                    return 0;
            }
        }

        public void Insert(Tree value)
        {
            if (Left == null)
                Left = value;
            else if (Right == null)
                Right = value;
            else
                throw new Exceptions.PsimulexCoreException("A BinaryTree can have just two child.");
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.BinaryTree; } }
        protected override System.Collections.IEnumerable GetAsEnumerable()
        {
            return ToPostOrderList();
        }

        private BaseTypeList ToPostOrderList()
        {
            var btl = new BaseTypeList();
            if (Value != null)
                btl.Add(Value);
            if (Left != null)
                btl.AddRange(Left.ToPostOrderList());
            if (Right != null)
                btl.AddRange(Right.ToPostOrderList());
            return btl;
        }

        // Preorder,Inorder,Szintfolytonos ( Propertivel lehetne állítani, hogy írja ki, hogy járja be )

        public override BaseType Index(int index)
        {
            if (index == 0)
                return Left;
            else if (index == 1)
                return Right;
            else
                throw new Exceptions.IndexOutOfRangeException(index, 0, 1);
        }

        public override int Size { get { return ToPostOrderList().Count; } }

        public override BaseType Clone()
        {
            BaseTypeList btl = ToPostOrderList();
            if (btl.Count != 0)
                return new Tree(btl);
            else
                return new Tree();
        }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            return ToPostOrderList().IsEqualTo(value.ToBinaryTree().ToPostOrderList());
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            Value = value.ToBinaryTree().Value.Clone();
            Left = value.ToBinaryTree().Left.Clone();
            Right = value.ToBinaryTree().Right.Clone();
        }

        /*
        public override void Add(BaseType value) 
        {
            // Can make a new node and the left operand will be the Left and the right the Right
        }
        */

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            // PostOrderToString
            string str = "";
            if(Value != null)
                str = Value.ToString();            
            str += "( ";
            if (Left != null)
                str += Left.ToString() + ", ";
            if (Right != null)
                str += Right.ToString();
            str += " )";
            return str;                
        }
                
        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return new Array(ToPostOrderList()); }
        public override List ToList() { return new List(ToPostOrderList()); }
        public override Set ToSet() { return new Set(ToPostOrderList()); }
        public override Stack ToStack() { return new Stack(ToPostOrderList()); }
        public override Queue ToQueue() { return new Queue(ToPostOrderList()); }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(ToPostOrderList()); }

        //public override LinkedList ToLinkedList() { throw new PsimulexCoreException("Invalid operation"); }
        //public override Graph ToGraph() { throw new PsimulexCoreException("Invalid operation"); }
        //public override GraphEdge ToGraphEdge() { throw new PsimulexCoreException("Invalid operation"); }
        //public override GraphNode ToGraphNode() { throw new PsimulexCoreException("Invalid operation"); }
        //public override Tree ToTree() { throw new PsimulexCoreException("Invalid operation"); }
        public override BinaryTree ToBinaryTree() { return this; }

        #endregion
    }
}
