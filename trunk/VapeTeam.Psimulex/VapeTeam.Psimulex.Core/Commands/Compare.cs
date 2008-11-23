using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Binary comparison.
    /// </summary>
    public class Compare : CommandBase
    {
        public enum ComparisonModes
        {
            Undefined,
            Equal,
            NotEqual,
            LessThan,
            LessThanOrEqual,
            GreaterThan,
            GreaterThanOrEqual,
        }

        private ComparisonModes mode;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            bool result = false;

            BaseType op2 = context.RunStack.Pop().Clone();
            BaseType op1 = context.RunStack.Pop().Clone();

            TypeHierarchy.OrderTypes(ref op1, ref op2);

            using (new Memory.AutoCleanup())
            {
                switch (mode)
                {
                    case ComparisonModes.Undefined:
                        break;
                    case ComparisonModes.Equal:
                        result = op1.EqualsTo(op2);
                        break;
                    case ComparisonModes.NotEqual:
                        result = op1.NotEqualsTo(op2);
                        break;
                    case ComparisonModes.LessThan:
                        result = op1.IsLessThan(op2);
                        break;
                    case ComparisonModes.LessThanOrEqual:
                        result = op1.IsLessThanOrEqual(op2);
                        break;
                    case ComparisonModes.GreaterThan:
                        result = op1.IsGreaterThan(op2);
                        break;
                    case ComparisonModes.GreaterThanOrEqual:
                        result = op1.IsGreaterThanOrEqual(op2);
                        break;

                    default:
                        break;
                }
            }

            op1.Delete();
            op2.Delete();

            context.RunStack.Push(ValueFactory.Create(result));
        }

        #endregion
            
        public Compare(ComparisonModes mode)
        {
            this.mode = mode;
        }

        public override string ToString()
        {
            switch (this.mode)
            {
                case ComparisonModes.Equal:
                    return "compare ==";
                case ComparisonModes.NotEqual:
                    return "compare !=";
                case ComparisonModes.LessThan:
                    return "compare <";
                case ComparisonModes.LessThanOrEqual:
                    return "compare <=";
                case ComparisonModes.GreaterThan:
                    return "compare >";
                case ComparisonModes.GreaterThanOrEqual:
                    return "compare >=";
                case ComparisonModes.Undefined:
                default:
                    return "compare ??";
            }
        }
    }
}
