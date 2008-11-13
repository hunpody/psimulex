using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple Indexable Stack.
    /// </summary>
    public class Stack : AbstractList
    {
        #region Constructors

        public Stack()
        {
        }

        public Stack(BaseType value)
            : base(value)
        {
        }

        public Stack(IEnumerable<BaseType> rep)
            : base(rep)
        {
        }

        #endregion

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Set; }
        }

        #region Own Members

        public void Push(BaseType value)
        {
            PushFront(value);
        }

        public BaseType Peek()
        {
            return Top;
        }

        public BaseType Top
        {
            get
            {
                return Front;
            }
        }

        public BaseType Pop()
        {
            return RemoveFront();
        }

        #endregion

        public override BaseType Clone()
        {
            return new Stack(rep);
        }
    }
}
