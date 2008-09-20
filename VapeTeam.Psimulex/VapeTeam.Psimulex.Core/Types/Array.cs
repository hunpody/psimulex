using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Array : AbstractCollection
    {
        protected TypeEnum initializatorType;
        protected int size;

        protected List<BaseType> rep;

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
        /// For conversions.
        /// </summary>
        /// <param name="value"></param>
        public Array(BaseType value)
            : this(value.TypeEnum, 1)
        {
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Array; }
        }

        public override BaseType Index(int index)
        {
            return ListIndexing(rep, index);
        }

        public override int Size
        {
            get { return size; }
        }
    }
}
