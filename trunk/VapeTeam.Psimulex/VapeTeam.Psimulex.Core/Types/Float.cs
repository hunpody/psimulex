using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Float : BaseType
    {
        private float value;

        public Float(float value)
        {
            this.value = value;
        }

        public Float()
            :this(0)
        {
        }

        #region Overridden operations

        public override bool IsLessThan(BaseType value)
        {
            return this.value < value.ToFloat();
        }

        public override void Add(BaseType value)
        {
            this.value += value.ToFloat();
        }

        public override void Subtract(BaseType value)
        {
            this.value -= value.ToFloat();
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
            this.value *= value.ToFloat();
        }

        public override void Divide(BaseType value)
        {
            this.value /= value.ToFloat();
        }

        public override void Power(BaseType value)
        {
            this.value = (long) Math.Pow((double)this.value, (double) value.ToFloat());
        }

        public override void Modulo(BaseType value)
        {
            this.value %= value.ToFloat();
        }

        public override void Assign(BaseType value)
        {
            this.value = value.ToFloat();
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Float; }
        }

        #endregion    

    }
}
