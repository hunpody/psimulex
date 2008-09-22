using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Return : CommandBase
    {
        /// <summary>
        /// True if the function returns something.
        /// </summary>
        public bool HasReturnValue { get; private set; }

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            BaseType returnValue = null;
            if (HasReturnValue && !context.RunStack.IsEmpty)
            {
                returnValue = context.RunStack.Pop();
            }
            
            context.PopState();

            if (returnValue != null)
            {
                context.RunStack.Push(returnValue);
            }
        }

        #endregion

        public Return(bool hasReturnValue)
        {
            this.HasReturnValue = hasReturnValue;
        }

        public Return()
            : this(true)
        {

        }

        public override string ToString()
        {
            if (HasReturnValue)
            {
                return "return";
            }
            else
            {
                return "return_void";
            }
        }
    }
}
