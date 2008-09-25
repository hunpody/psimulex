using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Performs an assignment. The first value is the value to assign and the second is the target value.
    /// </summary>
    public class Assign : CommandBase
    {
        public bool PushResult { get; set; }
        public bool ReverseAssign { get; set; }

        public override void Do(ICommandContext context)
        {
            BaseType valueToAssign;
            BaseType targetValue;

            if (!ReverseAssign)
            {
                valueToAssign = context.RunStack.Pop();
                targetValue = context.RunStack.Pop();
            }
            else
            {
                targetValue = context.RunStack.Pop();
                valueToAssign = context.RunStack.Pop(); 
            }

            targetValue.Assign(valueToAssign);

            if (PushResult)
            {
                context.RunStack.Push(targetValue);
            }
        }

        /// <summary>
        /// Initializes a new Assign command. The result won't be pushed back.
        /// </summary>
        public Assign()
            : this(false,false)
        {
        }

        /// <summary>
        /// Initializes a new Assign command. The result will be pushed back.
        /// </summary>
        /// <param name="pushResult"></param>
        public Assign(bool pushResult)
        {
            this.PushResult = pushResult;
            this.ReverseAssign = false;
        }

        public Assign(bool pushResult, bool reverseAssign)
        {
            this.PushResult = pushResult;
            this.ReverseAssign = reverseAssign;
        }

        public override string ToString()
        {
            if (!PushResult)
            {
                return ( ReverseAssign ? "revert " : "" ) + "assign";
            }
            else
            {
                return ( ReverseAssign ? "revert " : "" ) + "assign_and_push";
            }
        }
    }
}
