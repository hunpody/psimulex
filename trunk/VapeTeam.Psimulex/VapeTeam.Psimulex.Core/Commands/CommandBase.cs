using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    public abstract class CommandBase : ICommand
    {
        #region ICommand Members

        private Process process;

        public virtual Process HostProcess
        {
            get
            {
                return process;
            }
        }

        public CommandBase()
        {

        }

        public abstract void Do(ICommandContext context);

        #endregion
    }
}
