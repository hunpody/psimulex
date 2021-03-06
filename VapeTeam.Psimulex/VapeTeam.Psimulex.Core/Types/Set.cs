﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Set : AbstractList
    {
        #region Constructors

        public Set()
        {
        }

        public Set(BaseType value)
            : base(value)
        {
        }

        public Set(IEnumerable<BaseType> rep)
            : base(rep.Distinct())
        {
        }

        #endregion

        #region Own Members

        public override void Insert(BaseType value)
        {
            if (!Contains(value))
            {
                base.Insert(value);
            }
        }

        /// <summary>
        /// Removes the value from the set that is equal to the parameter.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public BaseType Remove(BaseType value)
        {
            BaseType ret = rep.Find(item => item.EqualsTo(value));
            if (ret != null)
            {
                rep.Remove(ret);
                OnChanged();
            }
            return ret;
        }

        public bool Has(BaseType value)
        {
            return Contains(value);
        }

        public bool Contains(BaseType value)
        {
            return rep.Exists(x => x.EqualsTo(value));
        }

        #endregion

        #region Implemented Members

        public override TypeIdentifier Type
        {
            get
            {
                return TypeEnum.Set;
            }
        }

        #endregion

        #region Relational comparison operators

        #endregion

        #region Operator Members

        /// <summary>
        /// Union
        /// </summary>
        /// <param name="value"></param>
        public override void Add(BaseType value)
        {
            rep.AddRange(value.ToSet().AsEnumerable().Where(x => !Contains(x)));
            OnChanged();
        }

        /// <summary>
        /// Intersection
        /// </summary>
        /// <param name="value"></param>
        public override void Multiply(BaseType value)
        {
            var valueSet = value.ToSet();
            rep.RemoveAll(x => !valueSet.Contains(x));
            OnChanged();
        }

        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="value"></param>
        public override void Subtract(BaseType value)
        {
            Divide(value);
        }

        /// <summary>
        /// Division
        /// </summary>
        /// <param name="value"></param>
        public override void Divide(BaseType value)
        {
            var valueSet = value.ToSet();
            rep.RemoveAll(x => valueSet.Contains(x));
            OnChanged();
        }

        #endregion

        public override BaseType Clone()
        {
            return new Set(rep);
        }

        protected override string DecorateToString(string s)
        {
            return string.Format("{{{0}}}", s);
        }
    }
}
