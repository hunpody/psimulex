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
        private string typeName;
        private string name;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            BaseType value = context.RunStack.Pop();
            context.AddVariable(name, value);
        }

        #endregion

        public Initialize(string name, TypeEnum type)
        {
            this.name = name;
            this.type = type;
        }

        //public Initialize(string name, string typeName)
        //{
        //    this.name = name;
        //    this.typeName = typeName;
        //}

        public Initialize(string name)
            : this(name, TypeEnum.Undefined)
        {
        }

        public override string ToString()
        {
            if (type == TypeEnum.Undefined)
            {
                return string.Format("initialize {0}", type.ToString());
            }
            else
            {
                return string.Format("initialize {0} {1}", type.ToString(), name);
            }
        }
    }
}
