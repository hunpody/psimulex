using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Simply pops and throws away a value.
    /// </summary>
    public class Duplicate : CommandBase
    {
        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            BaseType popped = context.RunStack.Pop();
            context.RunStack.Push(popped.Clone().Dereference());
            context.RunStack.Push(popped);
        }

        #endregion

        public override string ToString()
        {
            return "duplicate";
        }
    }
}
