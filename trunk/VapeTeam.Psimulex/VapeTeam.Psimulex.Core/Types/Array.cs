using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Advenced Array Type.
    /// It can be resize and it will be have more built in function.
    /// </summary>
    public class Array : AbstractCollection
    {
        #region Represenation

        protected TypeEnum initializatorType;
        protected int size;
        protected BaseTypeList rep;

        #endregion

        #region Constructors

        public Array(TypeEnum initializatorType, int size)
        {
            this.initializatorType = initializatorType;
            this.size = size;
            rep = new BaseTypeList(size);
            InitializeArray();
        }

        protected void InitializeArray()
        {
            for (int i = 0; i < size; ++i)
            {
                rep.Add(ValueFactory.CreateValue(initializatorType));
            }
        }

        /// <summary>
        /// For conversions.
        /// </summary>
        /// <param name="value"></param>
        public Array(BaseType value)
            : this(value.TypeEnum, 1)
        {
            rep[0] = value.Clone();
        }

        /// <summary>
        /// For conversions from other collections.
        /// It clones the parameter.
        /// </summary>
        /// <param name="value"></param>
        public Array(BaseTypeList rep)
            :this(rep.Count != 0 ? rep[0].TypeEnum : TypeEnum.Void, rep.Count)
        {
            for (int i = 0; i < Count; i++)
                this.rep[i] = rep[i].Clone();
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.Array; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size
        {
            get { return size; }
            set
            {
                Resize(value);
            }
        }

        public override void Clear() 
        {
            rep = new BaseTypeList(size);
            InitializeArray();
        }

        //public override BaseType Clone() { return new Array(rep); }

        #endregion

        #region Own Members

        /// <summary>
        /// Resizes the array. Inserts new baseTypes or removes from the end.
        /// </summary>
        /// <param name="newSize"></param>
        protected virtual void Resize(int newSize)
        {
            if (newSize < 0)
            {
                throw new Exceptions.InvalidOperationException(string.Format("Cannot resize array to {0}. Please provide a non-negative size.", newSize));
            }

            if (newSize > size)
            {
                for (int i = size; i < newSize; ++i)
                {
                    rep.Add(ValueFactory.CreateValue(initializatorType));
                }
            }
            else
            {
                while (newSize < size--)
                {
                    rep.RemoveAt(rep.Count - 1);
                }
            }
            size = newSize;
        }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            return rep.IsEqualTo(value.ToArray().GetRepresentation() as BaseTypeList);
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            rep.AddRange((value.ToArray().GetRepresentation() as BaseTypeList).Clone());

            size = rep.Count;
            if (size != 0)
                initializatorType = rep[0].TypeEnum;
        }

        public override void Add(BaseType value)
        {
            rep.AddRange((value.ToArray().GetRepresentation() as BaseTypeList).Clone());
            size = rep.Count;
        }

        public override void Negate() { rep.Reverse(); }

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            return "[ " + rep.ToString() + "]";
        }

        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return this; }
        public override List ToList() { return new List(rep); }
        public override Set ToSet() { return new Set(rep); }
        public override Stack ToStack() { return new Stack(rep); }
        public override Queue ToQueue() { return new Queue(rep); }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(rep); }

        #endregion
    }
}
