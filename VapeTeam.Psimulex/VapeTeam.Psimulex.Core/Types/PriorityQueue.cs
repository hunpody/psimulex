using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Priority queue where the priority is represented with an integer.
    /// </summary>
    public class PriorityQueue : AbstractCollection
    {
        #region Representation

        public class Pair
        {
            public long Priority { get; set; }
            public BaseType Value { get; set; }

            public override string ToString()
            {
                return string.Format("(Priority: {0}, Value: {1})", Priority.ToString(), Value.ToString());
            }

            public override bool Equals(object obj)
            {
                var otherPair = obj as Pair;
                if (otherPair != null)
                {
                    return Priority == otherPair.Priority && Value.EqualsTo(otherPair.Value);
                }
                return base.Equals(obj);
            }

            public Pair Clone()
            {
                return new Pair
                {
                    Priority = this.Priority,
                    Value = Value.Clone()
                };
            }
        }

        private List<Pair> rep = new List<Pair>();

        #endregion

        #region Constructors

        public PriorityQueue()
        {
        }

        public PriorityQueue(BaseType value)
        {
            rep.Clear();
            Insert(0, value);
        }

        public PriorityQueue(IEnumerable<BaseType> list)
        {
            rep.AddRange(list.Select(item => new Pair { Priority = 0, Value = item }));
        }

        public PriorityQueue(IEnumerable<Pair> list)
        {
            rep.AddRange(list.Select(item => item.Clone()));
        }

        #endregion

        #region Own Members

        //public void In(BaseType key, BaseType value) { Insert(key, value); }
        public void Enqueue(long key, BaseType value) { Insert(key, value); }
        public void Insert(long key, BaseType value)
        {
            int index = rep.FindIndex(item => item.Priority < key);

            if (index == -1)
                index = rep.Count;

            rep.Insert(index, new Pair { Priority = key, Value = value });
            //if (Count == 0)
            //{
            //    rep.Add(new Pair { Priority = key, Value = value });
            //}
            //else
            //{
            //    for (int i = 0; i < Count; i++)
            //    {
            //        if (rep[i].Priority < key)
            //        {
            //            rep.Insert(i, new Pair { Priority = key, Value = value });
            //            return;
            //        }
            //    }
            //}
        }

        private void EnsureQueueIsNotEmpty(string message)
        {
            if (rep.Count == 0)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("PriorityQueue is empty. Cannot perform operation: {0}.", message));
            }
        }

        public BaseType Dequeue() { return RemoveMax(); }

        public BaseType RemoveMax()
        {
            EnsureQueueIsNotEmpty("get maximal element");
            BaseType ret = rep.First().Value;
            rep.RemoveAt(0);
            return ret;
        }

        public BaseType RemoveMin()
        {
            EnsureQueueIsNotEmpty("get minimal element");
            BaseType ret = rep[Count - 1].Value;
            rep.RemoveAt(Count - 1);
            return ret;
        }

        public BaseType Max
        {
            get
            {
                EnsureQueueIsNotEmpty("get maximal element");
                return rep[0].Value;
            }
        }

        public BaseType Min
        {
            get
            {
                EnsureQueueIsNotEmpty("get minimal element");
                return rep[Count - 1].Value;
            }
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.PriorityQueue; } }
        public override System.Collections.Generic.IEnumerable<BaseType> GetAsEnumerable() { return rep.Select(pair => pair.Value); }

        public override BaseType Index(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new Core.Exceptions.IndexOutOfRangeException(index, 0, Count - 1);
            }
            return rep[index].Value;
        }

        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }

        public override BaseType Clone()
        {
            return new PriorityQueue(this.rep);
        }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            var otherQueueRep = value.ToPriorityQueue().rep;

            var leftIter = rep.GetEnumerator();
            var rightIter = otherQueueRep.GetEnumerator();

            bool leftOver = false;
            bool rightOver = false;

            while ((leftOver = leftIter.MoveNext()) && (rightOver = rightIter.MoveNext()))
            {
                if (!leftIter.Current.Equals(rightIter.Current))
                {
                    return false;
                }
                leftOver = rightOver = false;
            }

            if (leftOver || rightOver)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            this.rep = value.ToPriorityQueue().rep.Select(pair => pair.Clone()).ToList();
        }

        public override void Add(BaseType value)
        {
            foreach (var pair in value.ToPriorityQueue().rep)
            {
                Insert(pair.Priority, pair.Value.Clone());
            }
        }

        #endregion

        #region Conversion to String

        public override string ToString()
        {
            return DecorateToString(string.Join(", ", rep.Select(item => item.ToString()).ToArray()));
        }

        protected override string DecorateToString(string s)
        {
            return string.Format("<{0}>", s);
        }

        #endregion

        #region Conversion

        public override PriorityQueue ToPriorityQueue() { return this; }

        #endregion
    }
}
