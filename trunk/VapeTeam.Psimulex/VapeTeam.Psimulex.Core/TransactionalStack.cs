using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// In Psimulex all stacks are based upon a special stack: TransactionalStack.
    /// As its name suggests, you can use it via transactions that can be commited or rolled back making
    /// it possible to group several operations.
    /// </summary>
    public class TransactionalStack<T> : Stack<T>
    {
        private List<ITransaction> transactions = new List<ITransaction>();

        /// <summary>
        /// Creates a new transaction. The changes you made will not affect this stack until you explicitly commit.
        /// </summary>
        /// <returns></returns>
        public StackTransaction<T> BeginTransaction()
        {
            var t = new StackTransaction<T>(this, this.stack, this.pointer);
            transactions.Add(t);
            return t;
        }

        public void CommitTransaction(StackTransaction<T> stackTransaction)
        {
            transactions.Remove(stackTransaction);
            transactions.ForEach(t => t.Invalidate());
            transactions.Clear();
        }

        internal void RollbackTransaction(StackTransaction<T> stackTransaction)
        {
            transactions.Remove(stackTransaction);
        }
    }

    /// <summary>
    /// The transaction that creates a snapshot of the original stack until you commit it.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackTransaction<T> : IStack<T>, ITransaction
    {
        protected TransactionalStack<T> originalStack;
        protected List<T> originalStackRep;
        protected int originalPointer;

        protected int currentPointer;
        protected Stack<T> tempStack;

        public StackTransaction(TransactionalStack<T> stack, List<T> stackRep, int pointer)
        {
            originalStack = stack;
            originalStackRep = stackRep;
            originalPointer = pointer;
            currentPointer = pointer;
            tempStack = new Stack<T>();
            Status = TransactionStates.Uncommitted;
        }

        public bool IsEmpty
        {
            get
            {
                return currentPointer < 0;
            }
        }

        public int Count
        {
            get
            {
                return currentPointer + 1;
            }
        }

        public T Pop()
        {
            // There is no item in the stack
            if (IsEmpty)
            {
                throw new StackOverflowException();
            }
            // The item is in the original stack
            else if (currentPointer <= originalPointer)
            {
                var ret = originalStackRep[currentPointer];
                --currentPointer;
                --originalPointer;
                return ret;
            }
            // The item is in the new stack
            else
            {
                var ret = tempStack.Pop();
                --currentPointer;
                return ret;
            }
        }

        public IEnumerable<T> Pop(int count)
        {
            List<T> poppedValues = new List<T>(count);
            for (int i = 0; i < count; ++i)
            {
                poppedValues.Add(Pop());
            }
            return poppedValues;
        }

        public void Push(T item)
        {
            tempStack.Push(item);
            ++currentPointer;
        }

        public T Top
        {
            get
            {
                // There is no item in the stack
                if (IsEmpty)
                {
                    throw new StackOverflowException();
                }
                // The item is in the original stack
                else if (currentPointer <= originalPointer)
                {
                    return originalStackRep[currentPointer];
                }
                // The item is in the new stack
                else
                {
                    return tempStack.Top;
                }
            }
        }

        public void Clear()
        {
            tempStack.Clear();
            currentPointer = -1;
            originalPointer = -1;
        }

        public IEnumerable<T> AsEnumerable()
        {
            List<T> values = new List<T>();

            values.AddRange(tempStack.AsEnumerable());
            values.AddRange(originalStackRep.Take(originalPointer + 1).Reverse());

            return values;
        }

        #region ITransaction Members

        public TransactionStates Status
        {
            get;
            internal set;
        }

        private void AssertUncommitted(string message)
        {
            if (Status != TransactionStates.Uncommitted)
            {
                throw new VapeTeam.Psimulex.Core.Exceptions.InvalidTransactionException(message);
            }
        }

        public void Invalidate()
        {
            if (Status == TransactionStates.Uncommitted)
                Status = TransactionStates.Invalid;
        }

        /// <summary>
        /// Applies all modifications made to the stack.
        /// After commit you cannot use this transaction anymore.
        /// </summary>
        public void Commit()
        {
            AssertUncommitted("You can only commit an uncommitted transaction");

            //int numberOfItemsToDelete = originalPointer - currentPointer + tempStack.Count;
            int numberOfItemsToDelete = originalStackRep.Count - originalPointer - 1;
            for (int i = 0; i < numberOfItemsToDelete; ++i)
            {
                originalStack.Pop();
            }
            var reversedTempStack = tempStack.Reverse();
            while (!reversedTempStack.IsEmpty)
            {
                var item = reversedTempStack.Pop();
                originalStack.Push(item);
            }

            tempStack.Clear();
            originalPointer = currentPointer;

            Status = TransactionStates.Committed;
            originalStack.CommitTransaction(this);
        }

        /// <summary>
        /// Rollback drops all information made in the transaction.
        /// </summary>
        public void Rollback()
        {
            AssertUncommitted("You can only rollback an uncommitted transaction");

            currentPointer = originalPointer = originalStackRep.Count - 1;
            tempStack.Clear();

            Status = TransactionStates.Rolledback;
            originalStack.RollbackTransaction(this);
        }

        #endregion
    }
}
