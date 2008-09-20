using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class BinaryOperation : CommandBase
    {
        public enum Operations
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Power,
            Modulo,
            LogicalXor,
            LogicalOr,
            LogicalAnd,
        }

        private Operations operation;

        public override void Do(ICommandContext context)
        {
            BaseType second = context.RunStack.Pop().Clone();
            BaseType first = context.RunStack.Pop().Clone();

            TypeHierarchy.OrderTypes(ref first, ref second);

            BaseType result = first;

            switch (operation)
            {
                case Operations.Addition:
                    first.Add(second);
                    break;
                case Operations.Subtraction:
                    first.Subtract(second);
                    break;
                case Operations.Multiplication:
                    first.Multiply(second);
                    break;
                case Operations.Division:
                    first.Divide(second);
                    break;
                case Operations.Power:
                    first.Power(second);
                    break;
                case Operations.Modulo:
                    first.Modulo(second);
                    break;
                case Operations.LogicalXor:
                    result = ValueFactory.Create(first && !second || !first && second);
                    break;
                case Operations.LogicalOr:
                    result = ValueFactory.Create(first || second);
                    break;
                case Operations.LogicalAnd:
                    result = ValueFactory.Create(first && second);
                    break;
                default:
                    break;
            }

            context.RunStack.Push(result);
        }

        public BinaryOperation(Operations operation)
        {
            this.operation = operation;
        }
    }
}
