using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Jump : CommandBase
    {
        private int pc;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            context.PC = pc;
        }

        #endregion

        public Jump(int pc)
        {
            this.pc = pc;
        }
    }
}
