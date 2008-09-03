using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using System.Reflection;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Calls a method of an object. The method is identified by its name.
    /// </summary>
    public class CallMethod : CommandBase
    {
        private string methodName;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            // It has to look up the availabe function names
            // IFunctionLookup

            BaseType value = context.RunStack.Pop();

            var method = value.GetType().GetMethod(methodName,
                System.Reflection.BindingFlags.IgnoreCase |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.IgnoreCase);

            if (method != null)
            {
                var methodParameterInfos = method.GetParameters();
                var poppedValues = context.RunStack.Pop(methodParameterInfos.Length).Reverse();

                object[] convertedParameters =
                    ValueFactory.TransformBaseTypeArrayToDotnetType(poppedValues, methodParameterInfos.Select(pi => pi.ParameterType).ToArray());

                // Make the call
                var returnValue = method.Invoke(value, convertedParameters);

                // Push the returned value
                if (returnValue != null)
                {
                    context.RunStack.Push(ValueFactory.Create(returnValue));
                }
            }
            else
            {
                throw new PsimulexCoreException(string.Format("The type {0} has no such method: {1}.", value.GetTypeName(),  methodName));
            }
        }

        #endregion

        public CallMethod(string methodName)
        {
            this.methodName = methodName;
        }
    }
}
