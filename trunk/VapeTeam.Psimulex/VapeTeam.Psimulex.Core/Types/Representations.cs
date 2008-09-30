using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// This Type is the representation of all sequential collection.
    /// List, Set, Stack, Array, Queue, PriorityQueue
    /// </summary>
    public class BaseTypeList : List<BaseType>
    {
        public BaseTypeList()
        { }

        public BaseTypeList(int capacity)
            : base(capacity)
        { }

        /// <summary>
        /// It Clones All Of the elements.
        /// </summary>
        /// <returns></returns>
        public BaseTypeList Clone()
        {
            BaseTypeList btl = new BaseTypeList();
            foreach (var item in this)
                btl.Add(item.Clone());
            return btl;
        }

        public bool IsEqualTo(BaseTypeList btl)
        {
            if (Count != btl.Count)
                return false;
            else
                for (int i = 0; i < Count; i++)
                    if (this[i].NotEqualsTo(btl[i]))
                        return false;
            return true;
        }

        public override string ToString()
        {
            string str = "";
            this.ForEach(item => str += (item.ToString() + (item == this.Last<BaseType>() ? " " : ", ")));
            return str;
        }
    }
}
