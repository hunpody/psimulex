using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Exceptions;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Call can be initialized with an address or a function name.
    /// </summary>
    public class Call : CommandBase
    {
        private string functionName;
        private int functionAddress;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            if (!string.IsNullOrEmpty(functionName))
            {
                CallByName(context);
            }
            else
            {
                CallByAddress(context);
            }
        }

        private void CallByAddress(ICommandContext context)
        {
            context.PushState();
            context.PC = functionAddress;
        }

        private void CallByName(ICommandContext context)
        {
            // It has to look up the availabe function names
            // IFunctionLookup?
            var function = context.FunctionLookup.GetFunctionByName(functionName);

            if (function == null)
            {
                throw new PsimulexCoreException("Call to an undefined function: " + functionName);
            }

            if (function.IsUserDefined)
            {
                // Just jump to its entry point.
            }
            else
            {
                // Pack each parameter, and Invoke.

                Stack<BaseType> poppedValues = new Stack<BaseType>();
                var parameters = new List<BaseType>(function.ParametersCount);
                for (int i = 0; i < function.ParametersCount; ++i)
                {
                    poppedValues.Push(context.RunStack.Pop());
                }

                parameters.AddRange(poppedValues.AsEnumerable());

                // Make the call
                var returnValue = context.System.SystemCall(function, parameters);

                // Push the returned value
                if (function.HasReturnValue)
                {
                    context.RunStack.Push(returnValue);
                }
            }
        }

        public Call(string procedureName)
        {
            this.functionName = procedureName;
        }

        public Call(int address)
        {
            this.functionAddress = address;
        }

        #endregion
    }
}
