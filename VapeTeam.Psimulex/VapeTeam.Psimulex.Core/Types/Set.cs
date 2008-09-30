using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Set : AbstractCollection
    {
        #region Represenation

        private BaseTypeList rep = new BaseTypeList();

        #endregion

        #region Constructors

        public Set()
        {
        }

        public Set(BaseType value)
        {
            rep.Add(value.Clone());
        }

        public Set(BaseTypeList rep)
        {
            this.rep.Clear();
            rep.ForEach(item => Insert(item.Clone()));
        }

        #endregion

        #region Own Members

        //public void In(BaseType value) { Insert(value); }
        public void Insert(BaseType value)
        {
            if (!Contains(value))
                rep.Add(value);
        }

        //public BaseType Out(BaseType value) { return Remove(value); }
        public BaseType Remove(BaseType value)
        {
            BaseType ret = rep.Find(item => item.EqualsTo(value));
            if (ret != null)
                rep.Remove(ret);
            return ret;
        }

        public bool IsIn(BaseType value) { return Contains(value); }
        public bool Contains(BaseType value)
        {
            foreach (var item in rep)
                if (item.EqualsTo(value))
                    return true;
            return false;
        }

        #endregion

        #region Implemented Members

        public override TypeEnum TypeEnum { get { return TypeEnum.Set; } }
        protected override System.Collections.IEnumerable GetAsEnumerable() { return rep; }
        protected override object GetRepresentation() { return rep; }
        public override BaseType Index(int index) { return ListIndexing(rep, index); }
        public override int Size { get { return rep.Count; } }
        public override void Clear() { rep.Clear(); }
        //public override BaseType Clone() { return new Set(rep); }

        #endregion

        #region Relational comparison operators

        public override bool EqualsTo(BaseType value)
        {
            return rep.IsEqualTo(value.ToSet().GetRepresentation() as BaseTypeList);
        }

        #endregion

        #region Operator Members

        public override void Assign(BaseType value)
        {
            rep.Clear();
            rep.AddRange((value.ToSet().GetRepresentation() as BaseTypeList).Clone());
        }

        /// <summary>
        /// Unio
        /// </summary>
        /// <param name="value"></param>
        public override void Add(BaseType value)
        {
            (value.ToSet().GetRepresentation() as BaseTypeList).ForEach(
                item => Insert(item)
                );
        }

        /// <summary>
        /// Cutting
        /// </summary>
        /// <param name="value"></param>
        public override void Multiply(BaseType value)
        {
            BaseTypeList removables = new BaseTypeList();
            foreach (var item in rep)
                if (!value.ToSet().Contains(item))
                    removables.Add(item);

            foreach (var item in removables)
                Remove(item);
        }

        /// <summary>
        /// Substracion
        /// </summary>
        /// <param name="value"></param>
        public override void Subtract(BaseType value) { Divide(value); }
        public override void Divide(BaseType value)
        {
            (value.ToSet().GetRepresentation() as BaseTypeList).ForEach(
                item => Remove(item)
                );
        }       

        #endregion

        #region Conversion To Primitive Type Members

        public override string ToString()
        {
            return "{ " + rep.ToString() + "}";
        }

        #endregion

        #region Conversion To BuiltIn Type Members

        public override Array ToArray() { return new Array(rep); }
        public override List ToList() { return new List(rep); }
        public override Set ToSet() { return this; }
        public override Stack ToStack() { return new Stack(rep); }
        public override Queue ToQueue() { return new Queue(rep); }
        public override PriorityQueue ToPriorityQueue() { return new PriorityQueue(rep); }

        #endregion
    }
}
