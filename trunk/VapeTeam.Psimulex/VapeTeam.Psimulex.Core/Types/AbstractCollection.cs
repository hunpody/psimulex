using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class AbstractCollection : BaseType, IIndexable
    {
        #region IIndexable Members

        public abstract BaseType Index(int index);

        /// <summary>
        /// Base method for accessing an IList element.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected BaseType ListIndexing(IList<BaseType> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new Core.Exceptions.IndexOutOfRangeException(index, 0, list.Count - 1);
            }
            return list[index];
        }

        public override BaseType ToReference()
        {
            return this;
        }

        #endregion

        #region Representation

        protected virtual object GetRepresentation()
        {
            throw new Exceptions.PsimulexCoreException(string.Format("Can no get representation of type {0}", TypeEnum));
        }

        #endregion

        #region Size

        public virtual int Size
        {
            get
            {
                throw new Exceptions.InvalidOperationException();
            }
            set
            {
                // Supress exception
                //throw new Exceptions.InvalidOperationException();
            }
        }

        public virtual int Length
        {
            get { return Size; }
        }

        public virtual int Count
        {
            get { return Size; }
        }

        public override long ToInt()
        {
            return Size;
        }

        public override int ToInt32()
        {
            return Size;
        }

        public override decimal ToDecimal()
        {
            return Size;
        }

        public override float ToFloat()
        {
            return Size;
        }

        public override bool EqualsTo(BaseType value)
        {
            // If collection, compare each element
            if (value is AbstractCollection)
            {
                var thisList = GetAsEnumerable().ToList();
                var valueList = (value as AbstractCollection).GetAsEnumerable().ToList();
                if (thisList.Count != valueList.Count)
                {
                    return false;
                }
                for (int i = 0; i < thisList.Count; ++i)
                {
                    if (thisList[i].NotEqualsTo(valueList[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            // else compare by integer (which will mean size)
            return ToInt() == value.ToInt();
        }


        //public override bool IsLessThan(BaseType value) { return ToInt() < value.ToInt(); }
        //public override bool IsLessThanOrEqual(BaseType value) { return ToInt() <= value.ToInt(); }
        //public override bool IsGreaterThan(BaseType value) { return ToInt() > value.ToInt(); }
        //public override bool IsGreaterThanOrEqual(BaseType value) { return ToInt() >= value.ToInt(); }


        #endregion

        #region Iterator

        public abstract System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable();

        public Iterator GetIterator()
        {
            return new Iterator(GetAsEnumerable());
        }

        public override Iterator ToIterator()
        {
            return GetIterator();
        }

        protected virtual string DecorateToString(string s)
        {
            return s;
        }

        public override string ToString()
        {
            string csv = string.Join(", ", GetAsEnumerable().Select(x => x.ToString()).ToArray());
            return DecorateToString(csv);
        }

        #endregion

        #region Clear

        public void Delete()
        {
            Clear();
        }

        public void Empty()
        {
            Clear();
        }

        public virtual void Clear()
        {
            throw new Exceptions.InvalidOperationException(string.Format("Cannot clear collection {0}.", TypeEnum));
        }

        #endregion

        #region IsEmpty

        public bool IsEmpty
        {
            get
            {
                return Size == 0 ? true : false;
            }
        }

        #endregion
    }
}
