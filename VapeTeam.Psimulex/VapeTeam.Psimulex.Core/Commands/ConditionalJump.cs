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

        /// <summary>
        /// Means that the condition will not be popped out from the stack if it is true.
        /// </summary>
        public bool IsSilent { get; set; }

        #endregion

        public override void Do(ICommandContext context)
        {
            bool value = false;
            if (IsSilent)
            {
                value = context.RunStack.Top.ToBoolean();
            }
            else
            {
                value = context.RunStack.Pop().ToBoolean();
            }

            if (value == Condition)
            {
                base.Do(context);
            }
        }

        #region Constructors

        public ConditionalJump(int pc, bool condition)
            : this(pc, condition, false,false)
        {
        }

        public ConditionalJump(int pc, bool condition, bool isRelative)
            : base(pc, isRelative)
        {
            this.Condition = condition;
            this.IsSilent = false;
        }

        public ConditionalJump(int pc, bool condition, bool isRelative, bool isScilent)
            : base(pc, isRelative)
        {
            this.Condition = condition;
            this.IsSilent = isScilent;
        }

        #endregion

        public override string ToString()
        {
            string isRelativeString = string.Empty;
            if (IsRelative)
                isRelativeString = "relative_";
            string postfix = string.Empty;
            if (IsSilent)
                postfix = " (silent)";
            return string.Format("{0}jump_if_{1} {2}{3}", isRelativeString, Condition.ToString().ToLower(), this.PC, postfix);
        }
    }

    #region Additional Jump commands

    public class RelativeConditionalJump : ConditionalJump
    {
        public RelativeConditionalJump(int pc, bool condition)
            : base(pc, condition, true)
        {
        }

        public RelativeConditionalJump(int pc, bool condition, bool isScilent)
            : base(pc, condition, true, isScilent)
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

    public class SilentRelativeJumpIfFalse : RelativeConditionalJump
    {
        public SilentRelativeJumpIfFalse(int pc)
            : base(pc, false, true)
        {
        }
    }

    public class SilentRelativeJumpIfTrue : RelativeConditionalJump
    {
        public SilentRelativeJumpIfTrue(int pc)
            : base(pc, true, true)
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
