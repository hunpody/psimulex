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

            TypeEnum biggerType = TypeHierarchy.GetBiggerType(first.Type, second.Type);
            first = first.ConvertTo(biggerType);
            second = second.ConvertTo(biggerType);

            // Note: Dereference has no effect on tests.
            BaseType result = first.Dereference().Clone();

            switch (operation)
            {
                case Operations.Addition:
                    result.Add(second);
                    break;
                case Operations.Subtraction:
                    result.Subtract(second);
                    break;
                case Operations.Multiplication:
                    result.Multiply(second);
                    break;
                case Operations.Division:
                    result.Divide(second);
                    break;
                case Operations.Power:
                    result.Power(second);
                    break;
                case Operations.Modulo:
                    result.Modulo(second);
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

        public override string ToString()
        {
            switch (operation)
            {
                case Operations.Addition:
                    return "add";
                case Operations.Subtraction:
                    return "subtract";
                case Operations.Multiplication:
                    return "multiply";
                case Operations.Division:
                    return "divide";
                case Operations.Power:
                    return "power";
                case Operations.Modulo:
                    return "modulo";
                case Operations.LogicalXor:
                    return "logical_xor";
                case Operations.LogicalOr:
                    return "logical_or";
                case Operations.LogicalAnd:
                    return "logical_and";
                default:
                    return "binary_operation ??";
            }
        }
    }
}
