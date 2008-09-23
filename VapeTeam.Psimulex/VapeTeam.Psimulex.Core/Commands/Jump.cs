using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// A Jumper command that can jump to absolute position as well as relatively.
    /// </summary>
    public class Jump : CommandBase
    {
        #region Public properties

        /// <summary>
        /// The target Program Counter position the command will jump to. 
        /// If the Jump is a Relative Jump then it is the amount of relocation.
        /// </summary>
        public int PC { get; set; }

        /// <summary>
        /// Tells whether the jump will set the Program Counter to an absolute or relative position.
        /// </summary>
        public bool IsRelative
        {
            get;
            private set;
        }

        #endregion

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            context.PC = CalculatePosition(context);
        }

        #endregion

        protected virtual int CalculatePosition(ICommandContext context)
        {
            if (IsRelative)
            {
                return context.PC + PC;
            }
            else
            {
                return PC;
            }
        }

        #region Constructors

        public Jump(int pc, bool isRelative)
        {
            this.PC = pc;
            this.IsRelative = isRelative;
        }

        public Jump(int pc)
            : this(pc, false)
        {
        }

        #endregion

        public override string ToString()
        {
            string isRelativeString = string.Empty;
            if (IsRelative)
                isRelativeString = "relative_";
            return string.Format("{0}jump {1}", isRelativeString, this.PC);
        }
    }

    public class RelativeJump : Jump
    {
        public RelativeJump(int pc)
            : base(pc, true)
        {
        }
    }
}
