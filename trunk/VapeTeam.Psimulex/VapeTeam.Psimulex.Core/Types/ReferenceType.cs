using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class ReferenceType : BaseType
    {
        private BaseType referencedValue;

        #region Clone and reference

        public override BaseType Clone()
        {
            return new ReferenceType(referencedValue);
        }

        public override BaseType ToReference()
        {
            return this;
        }

        public override BaseType Dereference()
        {
            return referencedValue;
        }

        #endregion

        #region Overriden methods mapped to the referenced value

        public override bool Equals(object obj)
        {
            return referencedValue.Equals(obj);
        }

        public override bool EqualsTo(BaseType value)
        {
            return referencedValue.EqualsTo(value);
        }

        public override bool IsGreaterThan(BaseType value)
        {
            return referencedValue.IsGreaterThan(value);
        }

        public override bool IsGreaterThanOrEqual(BaseType value)
        {
            return referencedValue.IsGreaterThanOrEqual(value);
        }

        public override bool IsLessThan(BaseType value)
        {
            return referencedValue.IsLessThan(value);
        }

        public override bool IsLessThanOrEqual(BaseType value)
        {
            return referencedValue.IsLessThanOrEqual(value);
        }

        public override bool NotEqualsTo(BaseType value)
        {
            return referencedValue.NotEqualsTo(value);
        }

        public override bool ToBoolean()
        {
            return referencedValue.ToBoolean();
        }

        public override long ToInt()
        {
            return referencedValue.ToInt();
        }

        public override object ToObject()
        {
            return referencedValue.ToObject();
        }

        public override string ToString()
        {
            return referencedValue.ToString();
        }

        #endregion

        #region Lifecycle methods

        public ReferenceType(BaseType value)
        {
            referencedValue = value;
        }

        #endregion
    }
}
