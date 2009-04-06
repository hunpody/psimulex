using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class AbstractCollection : BaseType, IIndexable
    {
        #region IIndexable Members

        public abstract BaseType Index(int index, ICommandContext context);

        /// <summary>
        /// Base method for accessing an IList element.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected BaseType ListIndexing(IList<BaseType> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new Core.Exceptions.IndexOutOfRangeException(index, 0, list.Count - 1);
            }
            return list[index];
        }

        #region Indexing Event

        public class IndexedEventArgs : EventArgs
        {
            public IndexedEventArgs()
            {
                IndexDimensions = new List<int>();

            }
            public int Index
            {
                get
                {
                    return IndexDimensions[0];
                }
                set
                {
                    if (IndexDimensions.Count == 0)
                    {
                        IndexDimensions.Add(value);
                    }
                    else
                    {
                        IndexDimensions[0] = value;
                    }
                }
            }

            /// <summary>
            /// The Program Counter pointing to the indexer command
            /// </summary>
            public int IP { get; set; }

            public List<int> IndexDimensions { get; set; }

            /// <summary>
            /// The length of the call stack. This is useful if you are interested in the indexing operations of a recursive function.
            /// </summary>
            public int CallStackDepth { get; set; }
        }

        public event EventHandler<IndexedEventArgs> Indexed;

        protected void OnIndexed(int index, ICommandContext context)
        {
            if (Indexed != null)
                Indexed(this, new IndexedEventArgs() { CallStackDepth = context.CallStack.Count, Index = index, IP = context.PC});
        }

        #endregion

        #endregion

        #region Representation

        //protected virtual object GetRepresentation()
        //{
        //    throw new Exceptions.PsimulexCoreException(string.Format("Can no get representation of type {0}", TypeEnum));
        //}

        #endregion

        #region Size

        public virtual int Size
        {
            get
            {
                throw new Exceptions.InvalidOperationException();
            }
            set
            {
                // Supress exception
                //throw new Exceptions.InvalidOperationException();
            }
        }

        public virtual int Length
        {
            get { return Size; }
        }

        public virtual int Count
        {
            get { return Size; }
        }

        public override long ToInt()
        {
            return Size;
        }

        public override int ToInt32()
        {
            return Size;
        }

        public override decimal ToDecimal()
        {
            return Size;
        }

        public override float ToFloat()
        {
            return Size;
        }

        public override bool EqualsTo(IBaseType value)
        {
            // If collection, compare each element
            if (value is AbstractCollection)
            {
                var thisList = AsEnumerable().ToList();
                var valueList = (value as AbstractCollection).AsEnumerable().ToList();
                if (thisList.Count != valueList.Count)
                {
                    return false;
                }
                for (int i = 0; i < thisList.Count; ++i)
                {
                    if (thisList[i].NotEqualsTo(valueList[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            // else compare by integer (which will mean size)
            return ToInt() == value.ToInt();
        }


        //public override bool IsLessThan(BaseType value) { return ToInt() < value.ToInt(); }
        //public override bool IsLessThanOrEqual(BaseType value) { return ToInt() <= value.ToInt(); }
        //public override bool IsGreaterThan(BaseType value) { return ToInt() > value.ToInt(); }
        //public override bool IsGreaterThanOrEqual(BaseType value) { return ToInt() >= value.ToInt(); }


        #endregion

        #region Iterator

        public abstract System.Collections.Generic.IEnumerable<BaseType> AsEnumerable();

        public Iterator GetIterator()
        {
            return new Iterator(AsEnumerable());
        }

        public override Iterator ToIterator()
        {
            return GetIterator();
        }

        /// <summary>
        /// Decorates the string representation of the collection with prefix and suffix in 
        /// order to support special notation of the different container types.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected virtual string DecorateToString(string s)
        {
            return s;
        }

        public override string ToString()
        {
            string csv = string.Join(", ", AsEnumerable().Select(x => x.ToString()).ToArray());
            return DecorateToString(csv);
        }

        #endregion

        #region Clear

        public void Delete()
        {
            Clear();
        }

        public void Empty()
        {
            Clear();
        }

        public virtual void Clear()
        {
            throw new Exceptions.InvalidOperationException(string.Format("Cannot clear collection {0}.", Type));
        }

        #endregion

        #region IsEmpty

        public bool IsEmpty
        {
            get
            {
                return Size == 0 ? true : false;
            }
        }

        #endregion

        #region Conversions

        public override Array ToArray()
        {
            return new Array(AsEnumerable());
        }

        public override List ToList()
        {
            return new List(AsEnumerable());
        }

        public override Set ToSet()
        {
            return new Set(AsEnumerable());
        }

        public override Stack ToStack()
        {
            return new Stack(AsEnumerable());
        }

        public override Queue ToQueue()
        {
            return new Queue(AsEnumerable());
        }

        public override PriorityQueue ToPriorityQueue()
        {
            return new PriorityQueue(AsEnumerable());
        }

        public override BaseType ToReference()
        {
            return new ReferenceType(this);
        }

        #endregion

    }
}
