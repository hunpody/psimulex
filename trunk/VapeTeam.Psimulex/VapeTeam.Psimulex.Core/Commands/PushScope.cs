using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class PushScope : CommandBase
    {
        public override void Do(ICommandContext context)
        {
            context.PushScope();
        }
    }
}
