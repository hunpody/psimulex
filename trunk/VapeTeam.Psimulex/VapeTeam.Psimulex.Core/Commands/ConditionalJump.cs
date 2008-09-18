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
        #region Public properties

        /// <summary>
        /// The condition of the jump. If it equals to the top of the runstack then the jump will be performed.
        /// </summary>
        public bool Condition
        {
            get;
            private set;
        }

        #endregion

        public override void Do(ICommandContext context)
        {
            if (context.RunStack.Pop().ToBoolean() == Condition)
            {
                base.Do(context);
            }
        }

        #region Constructors

        public ConditionalJump(int pc, bool condition)
            : this(pc, condition, false)
        {
        }

        public ConditionalJump(int pc, bool condition, bool isRelative)
            : base(pc, isRelative)
        {
            this.Condition = condition;
        }

        #endregion
    }

    #region Additional Jump commands

    public class RelativeConditionalJump : ConditionalJump
    {
        public RelativeConditionalJump(int pc, bool condition)
            : base(pc, condition, true)
        {
        }
    }

    public class RelativeJumpIfFalse : RelativeConditionalJump
    {
        public RelativeJumpIfFalse(int pc)
            : base(pc, false)
        {
        }
    }

    public class RelativeJumpIfTrue : RelativeConditionalJump
    {
        public RelativeJumpIfTrue(int pc)
            : base(pc, true)
        {
        }
    }

    public class JumpIfFalse : ConditionalJump
    {
        public JumpIfFalse(int pc)
            : base(pc, false)
        {
        }
    }

    public class JumpIfTrue : ConditionalJump
    {
        public JumpIfTrue(int pc)
            : base(pc, true)
        {
        }

    }

    #endregion
}
