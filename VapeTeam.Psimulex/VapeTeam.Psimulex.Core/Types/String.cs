﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class String : BaseType
    {
        // needless
        //
        //private ValueAccessor<string> rep;
        //private string value
        //{
        //    get { return rep ?? string.Empty; }
        //    set { 
        //        rep.Assign(value);
        //        Memory.Instance.ReAllocate(this);
        //    }
        //}

        private string value;

        public override int MemorySize
        {
            get
            {
                // 4 : the string object
                // 4 : the virtual character array object
                return 8 + (value ?? string.Empty).Length * 2;
            }
        }

        public String(string value)
        {
            //this.rep = new ValueAccessor<string>(value);
            this.value = value;
            OnChanged();
        }

        public String()
            : this(string.Empty)
        {
        }

        //protected override void OnChanged()
        //{
        //    Memory.Instance.ReAllocate(this);
        //    base.OnChanged();
        //}

        public override void Assign(BaseType value)
        {
            this.value = value.ToString();
            OnChanged();
        }

        public override void Add(BaseType value)
        {
            this.value += value.ToString();
            OnChanged();
        }

        public override string ToString()
        {
            return value;
        }

        public override object ToObject()
        {
            int _infinity = 0;
            if (TryConvertToInfinity(value, out _infinity))
            {
                return _infinity;
            }

            return value;
        }

        /// <summary>
        /// Converts the string literal to the current infinity representation (int.MaxValue).
        /// </summary>
        /// <param name="value"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        static private bool TryConvertToInfinity(string value, out int i)
        {
            if (value.ToLower() == "inf" || value.ToLower() == "infinity")
            {
                i = Int32.MaxValue;
                return true;
            }
            else if (value.ToLower().Replace(" ", "") == "-inf" || value.ToLower().Replace(" ", "") == "-infinity")
            {
                i = -Int32.MaxValue;
                return true;
            }
            i = 0;
            return false;
        }

        public override char ToChar()
        {
            if (string.IsNullOrEmpty(value))
                return (char)0;
            else
                return value[0];
        }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.String; }
        }

        /// <summary>
        /// ToUpper remains in the Psimulex Type System.
        /// </summary>
        /// <returns></returns>
        public String ToUpper()
        {
            return new String(value.ToUpper());
        }

        /// <summary>
        /// Contains gets out of the type system but still discoverable by the engine.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Contains(string s)
        {
            return value.Contains(s);
        }
    }
}
