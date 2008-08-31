using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Pusher Microlex command. It can push registers, constants or in-memory objects to the stack.
    /// </summary>
    public class Push : CommandBase
    {
        public ValueAccessModes AccessMode { get; private set; }

        private BaseType value;
        private string name;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            switch (AccessMode)
            {
                case ValueAccessModes.Constant:
                    context.RunStack.Push(value);
                    break;
                case ValueAccessModes.InMemory:
                    break;
                case ValueAccessModes.Register:
                    break;
                case ValueAccessModes.LocalVariable:
                    context.RunStack.Push(context.GetVariable(name));
                    break;
                default:
                    break;
            }

        }

        //public Push(BaseType value, ValueAccessModes accessMode)
        //{
        //    AccessMode = accessMode;
        //    this.value = value;
        //}

        public Push(string name, ValueAccessModes accessMode)
        {
            AccessMode = accessMode;
            this.name = name;
        }

        public Push(object value)
        {
            AccessMode = ValueAccessModes.Constant;
            this.value = ValueFactory.Create(value);
        }

        #endregion
    }
}
