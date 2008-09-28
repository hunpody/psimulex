using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple Indexable Stack.
    /// </summary>
    public class Stack : AbstractCollection
    {
        #region Represenation

        private List<BaseType> rep = new List<BaseType>();

        #endregion

        #region Constructors

        public Stack()
        {
        }

        #endregion

        #region Own Members

        public void Push(BaseType value) { Insert(value); }
        public void Insert(BaseType value) { rep.Add(value); }

        public BaseType Peek() { return Top; }
        public BaseType Top { get { return Index(rep.Count - 1); } }
        
        public BaseType Pop() { return Remove(); }
        public BaseType Remove()
        {
            BaseType top = Top;
            rep.RemoveAt(rep.Count - 1);
            return top;
        }

        public void Invert() { Reverse(); }
        public void Reverse()
        {
            rep.Reverse(); 
        }

        #endregion

        #region Overridden Members

        public override TypeEnum TypeEnum { get { return TypeEnum.Stack; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }

        #endregion
    }
}
