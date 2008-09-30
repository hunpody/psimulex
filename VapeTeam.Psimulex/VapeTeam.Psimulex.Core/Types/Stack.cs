using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple Indexable Stack.
    /// </summary>
    public class Stack : AbstractCollection
    {
        #region Represenation

        private BaseTypeList rep = new BaseTypeList();

        #endregion

        #region Constructors

        public Stack()
        {
        }

        public Stack(BaseType value)
        {
            rep.Add(value.Clone());
        }

        public Stack(BaseTypeList rep)
        {
            foreach (BaseType item in rep)
                this.rep.Add(item.Clone());
        }

        #endregion

        #region Own Members

        public void Push(BaseType value) { Insert(value); }
        public void Insert(BaseType value) { rep.Add(value); }

        public BaseType Peek() { return Top; }
        public BaseType Top { get { return Index(rep.Count - 1); } }
        
        public BaseType Pop() { return Remove(); }
        public BaseType Remove()
        {
            BaseType top = Top;
            rep.RemoveAt(rep.Count - 1);
            return top;
        }

        public void Invert() { Reverse(); }
        public void Reverse()
        {
            rep.Reverse(); 
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.Stack; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }
        //public override BaseType Clone() { return new Stack(rep); }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            return rep.IsEqualTo(value.ToStack().GetRepresentation() as BaseTypeList);
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            rep.AddRange((value.ToStack().GetRepresentation() as BaseTypeList).Clone());
        }

        public override void Add(BaseType value) { rep.AddRange((value.ToStack().GetRepresentation() as BaseTypeList).Clone()); }
        public override void Negate() { rep.Reverse(); }

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            return "[ " + rep.ToString() + ">";
        }

        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return new Array(rep); }
        public override List ToList() { return new List(rep); }
        public override Set ToSet() { return new Set(rep); }
        public override Stack ToStack() { return this; }
        public override Queue ToQueue() { return new Queue(rep); }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(rep); }

        #endregion
    }
}
