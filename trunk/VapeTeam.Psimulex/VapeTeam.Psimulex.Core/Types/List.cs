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

        #endregion

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.List; }
        }

        public void Insert(BaseType value)
        {
            rep.Add(value);
        }

        public override BaseType Index(int index)
        {
            return ListIndexing(rep, index);
        }

        public override int Size
        {
            get { return rep.Count; }
        }

        public BaseType First
        {
            get
            {
                return Index(0);
            }
        }

        public BaseType Last
        {
            get
            {
                return Index(rep.Count - 1);
            }
        }

        public void PushFront(BaseType value)
        {
            rep.Insert(0, value);
        }

        public void PushBack(BaseType value)
        {
            rep.Insert(rep.Count, value);
        }

        public void RemoveAt(int index)
        {
            rep.RemoveAt(index);
        }

        public void Clear()
        {
            rep.Clear();
        }
    }
}
