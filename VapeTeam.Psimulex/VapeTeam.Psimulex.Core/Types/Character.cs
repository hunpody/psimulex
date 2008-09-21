using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// A basic type representing a unicode character.
    /// </summary>
    public class Character : BaseType
    {
        private char value;

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Character; }
        }

        public override void Add(BaseType value)
        {
            this.value += value.ToChar();
        }

        public override void Assign(VapeTeam.Psimulex.Core.Types.BaseType value)
        {
            this.value = value.ToChar();
        }

        public override object ToObject()
        {
            return value;
        }

        public override long ToInt()
        {
            if ((int)value >= (int)'0' && (int)value <= (int)'9')
                return (int)value - (int)'0';
            else return base.ToInt();
        }

        public Character()
            : this((char)0)
        {
        }

        public Character(char c)
        {
            this.value = c;
            this.isConversionToScalarBasedOnToInt = true;
        }
    }
}
