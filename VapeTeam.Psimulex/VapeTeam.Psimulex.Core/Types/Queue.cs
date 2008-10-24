using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple Indexable Queue.
    /// </summary>
    public class Queue : AbstractList
    {
        #region Constructors

        public Queue()
        {
        }

        public Queue(BaseType value)
            : base(value)
        {
        }

        public Queue(IEnumerable<BaseType> rep)
            : base(rep)
        {
        }

        #endregion

        #region Own Members

        public void Enqueue(BaseType value)
        {
            Insert(value);
        }

        public BaseType Dequeue()
        {
            return Remove();
        }

        /// <summary>
        /// Removes the first value from the beginning of the queue.
        /// </summary>
        /// <returns></returns>
        public BaseType Remove()
        {
            return RemoveAt(0);
        }

        #endregion

        #region Overridden methods

        public override BaseType Clone()
        {
            return new Queue(rep);
        }

        protected override string DecorateToString(string s)
        {
            return string.Format(">{0}>", s);
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Queue; }
        }

        #endregion
    }
}