using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Call : CommandBase
    {
        private string functionName;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            // It has to look up the availabe function names
            // IFunctionLookup
            var function = context.FunctionLookup.GetFunctionByName(functionName);

            if (function.IsUserDefined)
            {
                // Just jump.
            }
            else
            {
                // Pack each parameter, and Invoke.

                var parameters = new List<BaseType>(function.ParametersCount);
                for (int i=0; i<function.ParametersCount; ++i)
                {
                    parameters.Add(context.RunStack.Pop());
                }

                var returnValue = context.System.SystemCall(function, parameters);
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

        #endregion
    }
}
