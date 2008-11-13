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

        /// <summary>
        /// This is the type of the values that the array is composed of.
        /// </summary>
        protected TypeIdentifier InitializatorType
        {
            get
            {
                if (_type.GenericType == null)
                    return TypeEnum.Undefined;
                return _type.GenericType;
            }
            set
            {
                _type.GenericType = value;
            }
        }

        protected int size;

        #endregion

        #region Constructors

        public Array(TypeIdentifier initializatorType, int size)
        {
            this.InitializatorType = initializatorType;
            this.size = size;
            rep = new List<BaseType>(size);
            this._type = new TypeIdentifier { TypeEnum = TypeEnum.Array, GenericType = initializatorType };
            InitializeArray();
        }

        protected void InitializeArray()
        {
            for (int i = 0; i < size; ++i)
            {
                rep.Add(ValueFactory.CreateValue(InitializatorType));
            }
        }

        /// <summary>
        /// Converting from scalar.
        /// </summary>
        /// <param name="value"></param>
        public Array(BaseType value)
            : this(value.Type, 1)
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
                InitializatorType = rep.First().Type;
            }
            else
            {
                InitializatorType = TypeEnum.Undefined;
            }
        }

        #endregion


        private TypeIdentifier _type = new TypeIdentifier { TypeEnum = TypeEnum.Array };

        public override TypeIdentifier Type
        {
            get { return _type; }
        }

        public override System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable()
        {
            return rep;
        }

        public override BaseType Index(int index)
        {
            return ListIndexing(rep, index);
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
                    rep.Add(ValueFactory.CreateValue(InitializatorType));
                }
            }
            else
            {
                while (newSize < oldSize--)
                {
                    rep.RemoveAt(rep.Count - 1);
                }
            }

            OnChanged();
        }

        #endregion

        #region Overridden methods

        protected override string DecorateToString(string s)
        {
            return string.Format("[{0}]", s);
        }

        public override void Add(BaseType value)
        {
            if (value.Type != this.Type.GenericType)
            {
                base.AddRange(value);
            }
            else
            {
                base.Add(value);
            }
        }

        #endregion

        #region Added By Vari To Try Something

        public override void Assign(BaseType value)
        {
            var otherArray = value.ToArray();
            if (otherArray.Size > this.Size)
                Resize(otherArray.Size);
            for (int i = 0; i < otherArray.Size; ++i)
            {
                rep[i] = otherArray.rep[i].Clone().ConvertTo(InitializatorType);
            }
            OnChanged();
            //if( size != 0 )
            //    base.Assign(value);
            //else
            //{
            //    rep.Clear();
            //    foreach (var item in value.ToArray().GetAsEnumerable())
            //    {
            //        rep.Add(item);                    
            //    }
            //    this.size = value.ToArray().Size;
            //    this.InitializatorType = value.ToArray().InitializatorType;
            //}
        }

        #endregion

    }
}
