using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Initialize : CommandBase
    {
        private TypeEnum type;
        private string name;

        /// <summary>
        /// True if the value should store only a reference to the assigner statement.
        /// </summary>
        public bool IsReference { get; set; }

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            BaseType value = context.RunStack.Pop();
            if (IsReference)
                value = value.ToReference();
            else
                value = value.Dereference();
            context.AddVariable(name, value.Clone());
        }

        #endregion

        public Initialize(string name, TypeEnum type)
        {
            this.name = name;
            this.type = type;
        }

        public Initialize(string name)
            : this(name, TypeEnum.Undefined)
        {
        }

        public override string ToString()
        {
            string referencePrefix = string.Empty;
            if (IsReference)
                referencePrefix = "&";

            if (type == TypeEnum.Undefined)
            {
                return string.Format("initialize {1}{0}", type.ToString(), referencePrefix);
            }
            else
            {
                return string.Format("initialize {2}{0} {1}", type.ToString(), name, referencePrefix);
            }
        }
    }
}
