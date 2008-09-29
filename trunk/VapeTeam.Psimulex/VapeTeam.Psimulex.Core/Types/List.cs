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

        private List<BaseType> rep = new List<BaseType>();

        #endregion

        #region Constructors

        public List()
        {
        }

        public List(BaseType value)
        {
            rep.Add(value);
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

        #region Overridden Members

        public override TypeEnum TypeEnum { get { return TypeEnum.List; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }

        #endregion
    }
}
