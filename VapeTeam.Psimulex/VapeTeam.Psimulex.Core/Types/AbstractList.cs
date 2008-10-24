using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class AbstractList : AbstractCollection
    {
        #region Represenation

        protected List<BaseType> rep = new List<BaseType>();

        #endregion

        #region Constructors

        public AbstractList()
        {
        }

        public AbstractList(BaseType value)
        {
            rep.Add(value.Clone());
        }

        public AbstractList(IEnumerable<BaseType> rep)
        {
            foreach (var value in rep)
            {
                this.rep.Add(value.Clone());
            }
        }

        #endregion

        #region ??

        public virtual void Insert(BaseType value)
        {
            rep.Add(value);
        }

        public virtual void InsertAt(int index, BaseType value)
        {
            rep.Insert(index, value);
        }

        public virtual BaseType Begin
        {
            get
            {
                return First;
            }
        }
        public virtual BaseType Front
        {
            get
            {
                return First;
            }
        }

        public virtual BaseType First
        {
            get
            {
                return rep.FirstOrDefault();
            }
        }

        public virtual BaseType End
        {
            get
            {
                return Last;
            }
        }

        public virtual BaseType Back
        {
            get
            {
                return Last;
            }
        }

        public virtual BaseType Last
        {
            get
            {
                return rep.LastOrDefault();
            }
        }

        public virtual void AddToBegin(BaseType value)
        {
            PushFront(value);
        }

        public virtual void PushFront(BaseType value)
        {
            rep.Insert(0, value);
        }

        public virtual void AddToEnd(BaseType value)
        {
            PushBack(value);
        }

        public virtual void PushBack(BaseType value)
        {
            rep.Insert(rep.Count, value);
        }

        public BaseType RemoveFirst()
        {
            return PopFront();
        }

        public BaseType RemoveFront()
        {
            return PopFront();
        }

        public BaseType PopFront()
        {
            BaseType first = First;
            rep.RemoveAt(0);
            return first;
        }

        public BaseType RemoveLast()
        {
            return PopBack();
        }

        public BaseType RemoveBack()
        {
            return PopBack();
        }

        public BaseType PopBack()
        {
            BaseType last = Last;
            rep.RemoveAt(rep.Count - 1);
            return last;
        }

        public BaseType DeleteAt(int index)
        {
            return RemoveAt(index);
        }

        public BaseType RemoveAt(int index)
        {
            var ret = rep[index];
            rep.RemoveAt(index);
            return ret;
        }

        public void Invert()
        {
            Reverse();
        }

        public void Reverse()
        {
            rep.Reverse();
        }

        #endregion

        #region Implemented Members


        public override System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable()
        {
            return rep;
        }

        public override BaseType Index(int index)
        {
            return ListIndexing(rep, index);
        }

        public override int Size
        {
            get { return rep.Count; }
        }

        public override void Clear()
        {
            rep.Clear();
        }


        #endregion

        #region Relational comparison operators

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep = value.ToList().rep.Select(v => v.Clone()).ToList();
        }

        public override void Add(BaseType value)
        {
            rep.AddRange(value.ToList().GetAsEnumerable());
        }

        public override void Negate()
        {
            rep.Reverse();
        }

        #endregion

        #region Conversion to collections

        #endregion
    }
}
