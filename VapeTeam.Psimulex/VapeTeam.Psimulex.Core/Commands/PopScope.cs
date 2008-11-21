using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class PopScope : CommandBase
    {
        public override void Do(ICommandContext context)
        {
            context.PopScope();
        }
    }
}
