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

        public override void Add(BaseType value)
        {
            referencedValue.Add(value);
        }

        public override BaseType ConvertTo(TypeIdentifier type)
        {
            return referencedValue.ConvertTo(type);
        }

        public override void Divide(BaseType value)
        {
            referencedValue.Divide(value);
        }

        public override string GetTypeName()
        {
            return referencedValue.GetTypeName();
        }

        public override void Modulo(BaseType value)
        {
            referencedValue.Modulo(value);
        }

        public override void Multiply(BaseType value)
        {
            referencedValue.Multiply(value);
        }

        public override void Negate()
        {
            referencedValue.Negate();
        }

        public override void Power(BaseType value)
        {
            referencedValue.Power(value);
        }

        public override void Subtract(BaseType value)
        {
            referencedValue.Subtract(value);
        }

        public override char ToChar()
        {
            return referencedValue.ToChar();
        }

        public override decimal ToDecimal()
        {
            return referencedValue.ToDecimal();
        }

        public override float ToFloat()
        {
            return referencedValue.ToFloat();
        }

        public override int ToInt32()
        {
            return referencedValue.ToInt32();
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

        public override Tree ToTree()
        {
            return referencedValue.ToTree();
        }

        public override void Assign(BaseType value)
        {
            this.referencedValue.Assign(value);
        }

        public override TypeIdentifier Type
        {
            get { return referencedValue.Type; }
        }

        #endregion

        #region Lifecycle methods

        public ReferenceType(BaseType value)
            : base(false)
        {
            referencedValue = value;
            value.Changed += new EventHandler<ValueChangedEventArgs>(value_Changed);
            DoAllocation();
        }

        void value_Changed(object sender, BaseType.ValueChangedEventArgs e)
        {
            OnChanged();
        }

        internal override void Delete()
        {
            referencedValue.Changed -= value_Changed;
            base.Delete();
        }

        #endregion
    }
}
