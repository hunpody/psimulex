using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Jumps if the top element of the runstack equals to the given condition.
    /// </summary>
    public class ConditionalJump : Jump
    {
        private bool condition;

        public override void Do(ICommandContext context)
        {
            if (context.RunStack.Pop().ToBoolean() == condition)
            {
                base.Do(context);
            }
        }

        public ConditionalJump(int pc, bool condition)
            : base(pc)
        {
            this.condition = condition;
        }
    }
}
