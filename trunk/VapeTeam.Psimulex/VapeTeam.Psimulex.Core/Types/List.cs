using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Half-road between the array and the linked list.
    /// </summary>
    public class List : AbstractCollection
    {
        #region Represenation

        private BaseTypeList rep = new BaseTypeList();

        #endregion

        #region Constructors

        public List()
        {
        }

        public List(BaseType value)
        {
            rep.Add(value.Clone());
        }

        public List(BaseTypeList rep)
        {
            this.rep.Clear();
            this.rep.AddRange(rep.Clone());
        }

        #endregion

        #region Own Members

        public void Insert(BaseType value)
        {
            rep.Add(value);
        }

        public void InsertAt(int index, BaseType value)
        {
            rep.Insert(index, value);
        }

        public BaseType Begint { get { return First; } }
        public BaseType Front { get { return First; } }
        public BaseType First { get { return Index(0); } }

        public BaseType End { get { return Last; } }
        public BaseType Back { get { return Last; } }
        public BaseType Last { get { return Index(rep.Count - 1); } }

        public void AddToBegin(BaseType value) { PushFront(value); }
        public void PushFront(BaseType value)
        {
            rep.Insert(0, value);
        }

        public void AddToEnd(BaseType value) { PushBack(value); }
        public void PushBack(BaseType value)
        {
            rep.Insert(rep.Count, value);
        }

        public BaseType RemoveFirst() { return PopFront(); }
        public BaseType RemoveFront() { return PopFront(); }
        public BaseType PopFront()
        {
            BaseType first = First;
            rep.RemoveAt(0);
            return first;
        }

        public BaseType RemoveLast() { return PopBack(); }
        public BaseType RemoveBack() { return PopBack(); }
        public BaseType PopBack()
        {
            BaseType last = Last;
            rep.RemoveAt(rep.Count - 1);
            return last;
        }

        public void DeleteAt(int index) { RemoveAt(index); }
        public void RemoveAt(int index)
        {
            rep.RemoveAt(index);
        }

        public void Invert() { Reverse(); }
        public void Reverse()
        {
            rep.Reverse(); 
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.List; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }
        //public override BaseType Clone() { return new List(rep); }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            /*
            List l = value.ToList();
            if (Count != l.Count)
                return false;
            for (int i = 0; i < Count; i++)
                if (Index(i).NotEqualsTo(l.Index(i)))
                    return false;
            return true;
            */

            /*
            if(Count != value.ToList().Count)
                return false;
            Iterator it1 = GetIterator();
            Iterator it2 = value.ToList().GetIterator();
            while (it1.MoveNext() && it2.MoveNext())
                if (it1.Current().NotEqualsTo(it2.Current()))
                    return false;
            return true;
            */
                
            return rep.IsEqualTo(value.ToList().GetRepresentation() as BaseTypeList);
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            rep.AddRange((value.ToList().GetRepresentation() as BaseTypeList).Clone());
        }

        public override void Add(BaseType value) { rep.AddRange((value.ToList().GetRepresentation() as BaseTypeList).Clone()); }
        public override void Negate() { rep.Reverse(); }

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            return "( " + rep.ToString() + ")";
        }

        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return new Array(rep); }
        public override List ToList() { return this; }
        public override Set ToSet() { return new Set(rep); }
        public override Stack ToStack() { return new Stack(rep); }
        public override Queue ToQueue() { return new Queue(rep); }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(rep); }

        #endregion

    }
}
