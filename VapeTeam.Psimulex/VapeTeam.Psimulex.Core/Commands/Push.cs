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

        #region ICommand Members

        public override void Do(ICommandContext context)
        {            
            throw new NotImplementedException();
        }

        public Push(BaseType value, ValueAccessModes accessMode)
        {
            AccessMode = accessMode;
        }

        public Push(object value)
            : this(ValueFactory.Create(value), ValueAccessModes.Constant)
        {
        }

        #endregion
    }
}
