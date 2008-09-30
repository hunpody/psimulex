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

        private BaseTypeList rep = new BaseTypeList();

        #endregion

        #region Constructors

        public Queue()
        {
        }

        public Queue(BaseType value)
        {
            rep.Add(value);
        }

        public Queue(BaseTypeList rep)
        {
            this.rep.Clear();
            this.rep.AddRange(rep.Clone());
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
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            return rep.IsEqualTo(value.ToQueue().GetRepresentation() as BaseTypeList);
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            rep.AddRange((value.ToQueue().GetRepresentation() as BaseTypeList).Clone());
        }

        public override void Add(BaseType value) { rep.AddRange((value.ToQueue().GetRepresentation() as BaseTypeList).Clone()); }
        //public override void Subtract(BaseType value) { base.Subtract(value); }
        public override void Negate() { rep.Reverse(); }
        //public override void Multiply(BaseType value) { base.Multiply(value); }
        //public override void Divide(BaseType value) { base.Divide(value); }
        //public override void Power(BaseType value) { base.Power(value); }
        //public override void Modulo(BaseType value) { base.Modulo(value); }

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            rep.Reverse();
            string str = ">In> ";
            rep.ForEach(item => str += (item.ToString() + (item == rep.Last<BaseType>() ? " " : ", ")));
            str += ">Out>";
            rep.Reverse();
            return str;
        }

        ////public override long ToInt() { return Size; }
        ////public override int ToInt32() { return Size; }
        ////public override decimal ToDecimal() { return Size; }
        ////public override float ToFloat() { return Size; }

        //public override bool ToBoolean() { throw new Exceptions.PsimulexCoreException(string.Format("Can not convert {0} type to boolean", TypeEnum); }
        //public override char ToChar() { throw new Exceptions.PsimulexCoreException(string.Format("Can not convert {0} type to char", TypeEnum); }

        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return new Array(rep); }
        public override List ToList() { return new List(rep); }
        public override Set ToSet() { return new Set(rep); }
        public override Stack ToStack() { return new Stack(rep); }
        public override Queue ToQueue() { return this; }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(rep); }

        //public override LinkedList ToLinkedList() { throw new PsimulexCoreException("Invalid operation"); }
        //public override Graph ToGraph() { throw new PsimulexCoreException("Invalid operation"); }
        //public override GraphEdge ToGraphEdge() { throw new PsimulexCoreException("Invalid operation"); }
        //public override GraphNode ToGraphNode() { throw new PsimulexCoreException("Invalid operation"); }
        //public override Tree ToTree() { throw new PsimulexCoreException("Invalid operation"); }
        //public override BinaryTree ToBinaryTree() { throw new PsimulexCoreException("Invalid operation"); }

        ////public override Iterator ToIterator() { return GetIterator(); }
        #endregion
    }
}