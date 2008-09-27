﻿using System;
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

        public override void Do(ICommandContext context)
        {
            BaseType valueToAssign = context.RunStack.Pop();
            BaseType targetValue = context.RunStack.Pop();

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
            : this(false)
        {
        }

        /// <summary>
        /// Initializes a new Assign command. The result will be pushed back.
        /// </summary>
        /// <param name="pushResult"></param>
        public Assign(bool pushResult)
        {
            this.PushResult = pushResult;
        }

        public override string ToString()
        {
            if (!PushResult)
            {
                return "assign";
            }
            else
            {
                return "assign_and_push";
            }
        }
    }
}
