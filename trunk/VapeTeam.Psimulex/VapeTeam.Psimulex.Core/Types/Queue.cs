using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple Indexable Queue.
    /// </summary>
    public class Queue : AbstractCollection
    {
        #region Represenation

        private List<BaseType> rep = new List<BaseType>();

        #endregion

        #region Constructors

        public Queue()
        {
        }

        #endregion

        #region Own Members

        //public void In(BaseType value) { Insert(value); }
        public void EnQueue(BaseType value) { Insert(value); }
        public void Insert(BaseType value)
        {
            rep.Add(value);
        }

        //public BaseType Out() { return Remove(); }
        public BaseType DeQueue() { return Remove(); }
        public BaseType Remove()
        {
            BaseType ret = rep[0];
            rep.RemoveAt(0);
            return ret;
        }

        public BaseType Begin { get { return First; } }
        public BaseType Front { get { return First; } }
        public BaseType First { get { return Index(0); } }

        public BaseType End { get { return Last; } }
        public BaseType Back { get { return Last; } }
        public BaseType Last { get { return Index(rep.Count - 1); } }

        public void Reverse() { rep.Reverse(); }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.Queue; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }

        #endregion

        #region Conversion To Primitive Type Members

        // ToInt, ToString ...

        #endregion

        #region Conversion To BuiltIn Type Members

        // ToList, ToSet ...

        #endregion

        #region Operator Members

        // Assign, Add ...

        #endregion

        /* ToDo:
         * ValueFactory.Create -> (Clone() miatt)
         * Operators, Conversions
         */
    }
}
