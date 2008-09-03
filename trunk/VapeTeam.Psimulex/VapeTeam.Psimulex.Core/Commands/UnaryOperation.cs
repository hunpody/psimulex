using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class UnaryOperation : CommandBase
    {
        public enum Operations
        {
            Negate,
            Plus,
            PrefixDecrement,
            PrefixIncrement,
            PostfixDecrement,
            PostfixIncrement,
            LogicalNot
        }

        private Operations operation;

        public override void Do(ICommandContext context)
        {
            BaseType value = context.RunStack.Pop();

            BaseType result = value;

            switch (operation)
            {
                case Operations.Negate:
                    result = value.Clone();
                    result.Negate();
                    break;
                case Operations.Plus:
                    // It does simply nothing. Completely useless.
                    break;
                case Operations.PrefixDecrement:
                    value.Subtract(ValueFactory.Create(1));
                    break;
                case Operations.PrefixIncrement:
                    value.Add(ValueFactory.Create(1));
                    break;
                case Operations.PostfixDecrement:
                    result = value.Clone();
                    value.Subtract(ValueFactory.Create(1));
                    break;
                case Operations.PostfixIncrement:
                    result = value.Clone();
                    value.Add(ValueFactory.Create(1));
                    break;
                case Operations.LogicalNot:
                    result = new VapeTeam.Psimulex.Core.Types.Boolean(!value.ToBoolean());
                    break;
                default:
                    break;
            }

            context.RunStack.Push(result);
        }

        public UnaryOperation(Operations operation)
        {
            this.operation = operation;
        }
    }
}
