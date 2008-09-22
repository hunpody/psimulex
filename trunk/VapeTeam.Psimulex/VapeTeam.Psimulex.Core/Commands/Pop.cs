using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Simply pops and throws away a value.
    /// </summary>
    public class Pop : CommandBase
    {
        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            context.RunStack.Pop();
        }

        #endregion

        public override string ToString()
        {
            return "pop";
        }
    }
}
