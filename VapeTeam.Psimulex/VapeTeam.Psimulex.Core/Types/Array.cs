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
    public class Array : AbstractList
    {
        #region Represenation

        protected TypeEnum initializatorType;
        protected int size;

        #endregion

        #region Constructors

        public Array(TypeEnum initializatorType, int size)
        {
            this.initializatorType = initializatorType;
            this.size = size;
            rep = new List<BaseType>(size);
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
        /// Converting from scalar.
        /// </summary>
        /// <param name="value"></param>
        public Array(BaseType value)
            : this(value.TypeEnum, 1)
        {
            rep[0] = value.Clone();
        }

        /// <summary>
        /// For conversions from other collections.
        /// </summary>
        /// <param name="value"></param>
        public Array(IEnumerable<BaseType> rep)
            : base(rep)
        {
            if (rep.Count() > 0)
            {
                initializatorType = rep.First().TypeEnum;
            }
            else
            {
                initializatorType = TypeEnum.Undefined;
            }
        }

        #endregion


        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Array; }
        }

        public override System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable()
        {
            return rep;
        }

        public override BaseType Index(int index)
        {
            return ListIndexing(rep, index);
        }

        public override void Clear()
        {
            rep = new BaseTypeList(size);
            InitializeArray();
        }

        public override BaseType Clone() 
        {
            return new Array(rep); 
        }

        #region Size and Resize

        public override int Size
        {
            get
            {
                return rep.Count;
            }

            set
            {
                Resize(value);
            }
        }

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
            int oldSize = Size;
            if (newSize > oldSize)
            {
                for (int i = oldSize; i < newSize; ++i)
                {
                    rep.Add(ValueFactory.CreateValue(initializatorType));
                }
            }
            else
            {
                while (newSize < oldSize--)
                {
                    rep.RemoveAt(rep.Count - 1);
                }
            }
            //size = newSize;
        }

        #endregion

        protected override string DecorateToString(string s)
        {
            return string.Format("[{0}]", s);
        }

    }
}
