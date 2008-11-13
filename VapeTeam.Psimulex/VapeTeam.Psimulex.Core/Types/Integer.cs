using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// A standard integer value.
    /// </summary>
    public class Integer : BaseType
    {
        private long value;

        public Integer(long value)
        {
            this.value = value;
        }

        public Integer()
            :this(0)
        {
        }

        #region Overridden operations

        public override bool IsLessThan(BaseType value)
        {
            return this.value < value.ToInt();
        }

        public override void Add(BaseType value)
        {
            this.value += value.ToInt();
            OnChanged();
        }

        public override void Subtract(BaseType value)
        {
            this.value -= value.ToInt();
            OnChanged();
        }

        public override object ToObject()
        {
            return value;
        }

        public override void Negate()
        {
            this.value = -this.value;
            OnChanged();
        }

        public override void Multiply(BaseType value)
        {
            this.value *= value.ToInt();
            OnChanged();
        }

        public override void Divide(BaseType value)
        {
            this.value /= value.ToInt();
            OnChanged();
        }

        public override void Power(BaseType value)
        {
            this.value = (long) Math.Pow((double)this.value, (double) value.ToInt());
            OnChanged();
        }

        public override void Modulo(BaseType value)
        {
            this.value %= value.ToInt();
            OnChanged();
        }

        public override void Assign(BaseType value)
        {
            this.value = value.ToInt();
            OnChanged();
        }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Integer; }
        }

        #endregion
    }
}
