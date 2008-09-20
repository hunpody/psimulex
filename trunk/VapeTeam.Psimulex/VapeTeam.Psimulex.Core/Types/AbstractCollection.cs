using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class AbstractCollection : BaseType, IIndexable
    {
        #region IIndexable Members

        //public virtual BaseType Index(int index)
        //{
        //    throw new NotImplementedException();
        //}

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

        public abstract int Size
        {
            get;
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
    }
}
