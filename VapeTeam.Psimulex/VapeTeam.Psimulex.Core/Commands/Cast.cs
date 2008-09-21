using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Performs an explicit cast on the top value and pushes back the result.
    /// </summary>
    public class Cast : CommandBase
    {
        private TypeEnum targetType;

        public override void Do(ICommandContext context)
        {
            context.RunStack.Push(context.RunStack.Pop().Clone().ConvertTo(targetType));
        }

        public Cast(TypeEnum targetType)
        {
            this.targetType = targetType;
        }
    }
}
