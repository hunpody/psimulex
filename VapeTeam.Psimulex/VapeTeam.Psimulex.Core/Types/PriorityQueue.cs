using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Simple indexable Priority Queue.
    /// It insert elements sorted.
    /// (Rightest is the smallest key. Leftest is the oldest and biggest key)
    /// It get the oldest( Min,Max ) elemen.
    /// </summary>
    public class PriorityQueue : AbstractCollection
    {
        #region Represenation

        public class Pair
        {
            public BaseType Key { get; set; }
            public BaseType Value { get; set; }

            public override string ToString()
            {
                return string.Format("( Key: {0}, Value: {1} )", Key.ToString(), Value.ToString());
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
            Insert(new Integer(0), value.Clone());
        }

        public PriorityQueue(BaseTypeList rep)
        {
            this.rep.Clear();
            rep.ForEach(item => this.Insert(new Integer(0), item.Clone() ));
        }

        #endregion

        #region Own Members

        //public void In(BaseType key, BaseType value) { Insert(key, value); }
        public void EnQueue(BaseType key, BaseType value) { Insert(key, value); }
        public void Insert(BaseType key, BaseType value)
        {
            if (Count == 0)
            {
                rep.Add(new Pair { Key = key, Value = value });
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    if (rep[i].Key.IsLessThanOrEqual(key))
                    {
                        rep.Insert(i, new Pair { Key = key, Value = value });
                        return;
                    }
                }
            }
        }
        
        //public BaseType Out() { return Remove(); }
        public BaseType DeQueue() { return Remove(); }
        public BaseType GetMax() { return Remove(); }
        public BaseType Remove()
        {
            if (Count == 0)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("Priority Queue is empty. Can not get Max element. "));
            }
            else
            {
                BaseType ret = rep[0].Value;
                ret = rep[0].Value;
                rep.RemoveAt(0);
                return ret;
            }
        }

        public BaseType GetMin()
        {
            if (rep.Count == 0)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("Priority Queue is empty. Can not get Min element. "));
            }
            else
            {
                BaseType ret = rep[Count - 1].Value;
                rep.RemoveAt(Count - 1);
                return ret;
            }
        }

        public BaseType Max
        {
            get
            {
                if (Count == 0)
                    throw new Exceptions.PsimulexCoreException(string.Format("Priority Queue is empty. Can not get Max element. "));
                else
                    return rep[0].Value;
            }
        }

        public BaseType Min
        {
            get
            {
                if (rep.Count == 0)
                    throw new Exceptions.PsimulexCoreException(string.Format("Priority Queue is empty. Can not get Min element. "));
                else
                    return rep[Count - 1].Value;
            }
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.PriorityQueue; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new Core.Exceptions.IndexOutOfRangeException(index, 0, Count - 1);
            }
            return rep[index].Value;    // Temporary solution. I want to create a Pair as BaseType
        }

        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }
        //public override BaseType Clone()
        //{
        //    PriorityQueue pq = new PriorityQueue();
        //    rep.ForEach(item => pq.Insert(item.Key.Clone(), item.Value.Clone()));
        //    return pq;
        //}

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            var list = value.ToPriorityQueue().GetRepresentation() as List<Pair>;
            if (Count != list.Count)
                return false;
            else
                for (int i = 0; i < Count; i++)
                    if (rep[i].Key.NotEqualsTo(list[i].Key) || rep[i].Value.NotEqualsTo(list[i].Value))
                        return false;
            return true;
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            (value.ToPriorityQueue().GetRepresentation() as List<Pair>).ForEach(
                item => Insert(item.Key.Clone(), item.Value.Clone())
                );
        }

        public override void Add(BaseType value) 
        { 
            (value.ToPriorityQueue().GetRepresentation() as List<Pair>).ForEach(
                item => Insert(item.Key.Clone(), item.Value.Clone())
                ); 
        }
        //public override void Negate() {}
        /* With negate can change that Remove is GetMax or GetMin. Not necessary yet. */

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            string str = "< ";
            rep.ForEach(item => str += item.ToString() + (item == rep.Last<Pair>() ? " " : ", "));
            str += ">";
            return str;
        }

        #endregion

        #region Conversion To BuiltIn Type Members

        private BaseTypeList ToBaseTypeList()
        {
            BaseTypeList btl = new BaseTypeList();
            rep.ForEach(item => btl.Add(item.Value.Clone()));
            return btl;
        }

        public override Array ToArray() { return new Array(ToBaseTypeList()); }
        public override List ToList() { return new List(ToBaseTypeList()); }
        public override Set ToSet() { return new Set(ToBaseTypeList()); }
        public override Stack ToStack() { return new Stack(ToBaseTypeList()); }
        public override Queue ToQueue() { return new Queue(ToBaseTypeList()); }
        public override PriorityQueue ToPriorityQueue() { return this; }

        #endregion
    }
}
