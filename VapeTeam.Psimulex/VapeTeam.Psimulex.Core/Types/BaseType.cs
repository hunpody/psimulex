using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class BaseType
    {
        public virtual object ToObject()
        {
            return this;
        }

        public virtual bool EqualsTo(BaseType value)
        {
            return ToObject().Equals(value.ToObject());
        }

        public virtual bool IsLessThan(BaseType value)
        {
            throw new PsimulexCoreException(string.Format("IsLessThan comparison operator not defined between {0} and {1}.",
                this.GetType(), value.GetType()));
        }

        public virtual bool NotEqualsTo(BaseType value)
        {
            return !EqualsTo(value);
        }

        public virtual bool IsLessThanOrEqual(BaseType value)
        {
            return EqualsTo(value) || IsLessThan(value);
        }

        public virtual bool IsGreaterThan(BaseType value)
        {
            return !EqualsTo(value) && !IsLessThan(value);
        }

        public virtual bool IsGreaterThanOrEqual(BaseType value)
        {
            return !IsLessThan(value);
        }

        public override string ToString()
        {
            return ToObject().ToString();
        }

        public virtual int ToInt()
        {
            object obj = ToObject();
            if (obj != null)
                return Convert.ToInt32(obj);
            else return 0;
        }
    }
}
