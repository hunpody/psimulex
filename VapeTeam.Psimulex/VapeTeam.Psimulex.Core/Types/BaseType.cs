using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class BaseType
    {
        public virtual string GetTypeName()
        {
            return GetType().Name;
        }

        #region Relational comparison operators

        public virtual bool EqualsTo(BaseType value)
        {
            return ToObject().Equals(value.ToObject());
        }

        public virtual bool IsLessThan(BaseType value)
        {
            throw new PsimulexCoreException(string.Format("IsLessThan comparison operator not defined between {0} and {1}.",
                this.GetTypeName(), value.GetTypeName()));
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

        #endregion

        #region Clone and reference operators

        /// <summary>
        /// Copies the value.
        /// </summary>
        /// <returns></returns>
        public virtual BaseType Clone()
        {
            return ValueFactory.Create(ToObject());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual BaseType ToReference()
        {
            return new ReferenceType(this);
        }

        public virtual BaseType Dereference()
        {
            return this;
        }

        #endregion

        #region

        public virtual void Assign(BaseType value)
        {
            throw new PsimulexCoreException(string.Format("Cannot assign a {0} value to {1}.", value.GetTypeName(), this.GetTypeName())); 
        }

        #endregion

        #region Unary arithmetical operations

        public virtual void Add(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot add {0} to {1}.",
                value.GetTypeName(), GetTypeName()));
        }

        public virtual void Subtract(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot subtract {0} from {1}.",
                value.GetTypeName(), GetTypeName()));
        }

        public virtual void Negate()
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot negate {0}.", GetTypeName()));
        }

        public virtual void Multiply(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot multiply {0} with {1}.",
                GetTypeName(), value.GetTypeName()));
        }

        public virtual void Divide(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot divide {0} with {1}.",
                GetTypeName(), value.GetTypeName()));
        }
       
        public virtual void Power(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot power {0} on {1}.",
                GetTypeName(), value.GetTypeName()));
        }

        public virtual void Modulo(BaseType value)
        {
            throw new Exceptions.InvalidOperationException(string.Format("Invalid operation. Cannot modulo {0} by {1}.",
                GetTypeName(), value.GetTypeName()));
        }

        #endregion

        #region Binary arithmetical operations

        #endregion

        #region Conversion operations

        public virtual object ToObject()
        {
            return this;
        }

        public override string ToString()
        {
            return ToObject().ToString();
        }

        public virtual long ToInt()
        {
            object obj = ToObject();
            if (obj != null)
                return Convert.ToInt64(obj);
            else return 0;
        }

        public virtual bool ToBoolean()
        {
            object obj = ToObject();
            if (obj != null)
                return Convert.ToBoolean(obj);
            else return false;
        }

        #endregion


        #region Implicit C# conversion operators

        public static implicit operator bool(BaseType value)
        {
            return value.ToBoolean();
        }

        #endregion
    }
}
