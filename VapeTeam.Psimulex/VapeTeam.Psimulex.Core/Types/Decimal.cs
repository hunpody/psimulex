using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Decimal : BaseType
    {
        private decimal value;

        public Decimal(decimal value)
        {
            this.value = value;
        }

        public Decimal()
            :this(0)
        {
        }

        #region Overridden operations

        public override bool IsLessThan(BaseType value)
        {
            return this.value < value.ToDecimal();
        }

        public override void Add(BaseType value)
        {
            this.value += value.ToDecimal();
        }

        public override void Subtract(BaseType value)
        {
            this.value -= value.ToDecimal();
        }

        public override object ToObject()
        {
            return value;
        }

        public override void Negate()
        {
            this.value = -this.value;
        }

        public override void Multiply(BaseType value)
        {
            this.value *= value.ToDecimal();
        }

        public override void Divide(BaseType value)
        {
            this.value /= value.ToDecimal();
        }

        public override void Power(BaseType value)
        {
            this.value = (long) Math.Pow((double)this.value, (double) value.ToDecimal());
        }

        public override void Modulo(BaseType value)
        {
            this.value %= value.ToDecimal();
        }

        public override void Assign(BaseType value)
        {
            this.value = value.ToDecimal();
        }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Decimal; }
        }

        #endregion    
    }
}
