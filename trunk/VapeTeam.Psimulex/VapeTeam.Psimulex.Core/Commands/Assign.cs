using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Assign : CommandBase
    {
        public override void Do(ICommandContext context)
        {
            BaseType valueToAssign = context.RunStack.Pop();
            BaseType targetValue = context.RunStack.Pop();
            targetValue.Assign(valueToAssign);
            context.RunStack.Push(targetValue);
        }
    }
}
