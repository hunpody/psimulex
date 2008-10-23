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
        private int parametersCount = -1;
        private int functionAddress;

        protected bool IsCallingByName
        {
            get { return !string.IsNullOrEmpty(functionName); }
        }

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
            Function function = null;
            if (parametersCount >= 0)
            {
                function = context.FunctionLookup.GetFunctionByNameAndParameterCount(functionName, parametersCount);
                if (function == null)
                {
                    throw new PsimulexCoreException(string.Format("Call to an undefined function: {0} with {1} parameters.", functionName, parametersCount));
                }
            }
            else
            {
                function = context.FunctionLookup.GetFunctionByName(functionName);
                if (function == null)
                {
                    throw new PsimulexCoreException("Call to an undefined function: " + functionName);
                }
            }

            if (function.IsUserDefined)
            {
                UserDefinedFunction udf = function as UserDefinedFunction;

                Stack<BaseType> parameters = new Stack<BaseType>();

                foreach (var param in udf.Parameters)
                {
                    var value = context.RunStack.Pop();
                    if (param.IsReference)
                    {
                        value = value.ToReference();
                    }
                    parameters.Push(value.Clone());
                }

                parameters = parameters.Reverse();

                context.PushState();

                foreach (var param in udf.Parameters)
                {
                    context.AddVariable(param.Name, parameters[udf.Parameters.IndexOf(param)]);
                }       

                // Just jump to its entry point.
                context.PC = udf.EntryPoint;
            }
            else
            {
                // Pack each parameter, and Invoke.

                Stack<BaseType> poppedValues = new Stack<BaseType>();
                var parameters = new List<BaseType>(function.ParameterCount);
                for (int i = 0; i < function.ParameterCount; ++i)
                {
                    poppedValues.Push(context.RunStack.Pop().Clone());
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

        public Call(string procedureName, int paramCount)
        {
            this.functionName = procedureName;
            this.parametersCount = paramCount;
        }

        public Call(int address)
        {
            this.functionAddress = address;
        }

        #endregion

        public override string ToString()
        {
            if (IsCallingByName)
            {
                return string.Format("call {0}", functionName);
            }
            else
            {
                return string.Format("call {0}", functionAddress.ToString());
            }
        }
    }
}
