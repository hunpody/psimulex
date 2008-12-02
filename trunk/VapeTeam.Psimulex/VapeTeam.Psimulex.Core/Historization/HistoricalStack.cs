using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Historization
{
    public class HistoricalStack<T> : TransactionalStack<T>
    {
        public class StackOperation : IHistoricalOperation
        {
            internal HistoricalStack<T> Stack { get; set; }
            public enum Opereations { Pop, Push };
            public Opereations Operation { get; set; }
            public T Argument { get; set; }

            public void Undo()
            {
                switch (Operation)
                {
                    case StackOperation.Opereations.Pop:
                        Stack.UnhistorizedPush(Argument);
                        break;
                    case StackOperation.Opereations.Push:
                        Stack.UnhistorizedPop();
                        break;
                    default:
                        break;
                }
            }

            public void Redo()
            {
                switch (Operation)
                {
                    case StackOperation.Opereations.Pop:
                        Stack.UnhistorizedPop();
                        break;
                    case StackOperation.Opereations.Push:
                        Stack.UnhistorizedPush(Argument);
                        break;
                    default:
                        break;
                }
            }

            public override string ToString()
            {
                return string.Format("{0} {1}", Operation, Argument);
            }
        }

        private IHistory history;

        public HistoricalStack(IHistory history)
        {
            this.history = history;
        }

        public override T Pop()
        {
            var poppedValue = base.Pop();
            history.Record(new StackOperation { Stack = this, Argument = poppedValue, Operation = StackOperation.Opereations.Pop });
            return poppedValue;
        }

        public override void Push(T item)
        {
            history.Record(new StackOperation { Stack = this, Operation = StackOperation.Opereations.Push, Argument = item });
            base.Push(item);
        }

        private T UnhistorizedPop()
        {
            return base.Pop();
        }

        private void UnhistorizedPush(T value)
        {
            base.Push(value);
        }
    }
}
