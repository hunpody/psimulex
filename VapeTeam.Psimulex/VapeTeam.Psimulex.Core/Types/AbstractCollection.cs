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

        #endregion

        #region Iterator

        protected abstract System.Collections.IEnumerable GetAsEnumerable();

        public Iterator GetIterator()
        {
            return new Iterator(GetAsEnumerable());
        }

        #endregion

        #region Clear

        public void Delete() { Clear(); }
        public void Empty() { Clear(); }
        public virtual void Clear() 
        {
            throw new Exceptions.InvalidOperationException(); 
        }        

        #endregion

        #region IsEmpty

        public bool IsEmpty { get { return Size == 0 ? true : false; } }

        #endregion
    }
}
