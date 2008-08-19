using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// In Psimulex all stacks are based upon a special stack: TransactionalStack.
    /// As its name suggests, you can use it via transactions that can be commited or rolled back.
    /// </summary>
    public class TransactionalStack<T>
    {
        /// <summary>
        /// The representation.
        /// </summary>
        private List<T> stack;

        /// <summary>
        /// The pointer to the top of the stack.
        /// </summary>
        private int pointer;

        public TransactionalStack ()
        {
            stack = new List<T>();
            pointer = -1;
        }

        public void Push(T elem)
        {
            stack.Add(elem);
            ++pointer;
        }

        public T Top
        {
            get 
            {
                if (pointer < 0 || pointer >= stack.Count)
                    throw new StackOverflowException();
                return stack[pointer];
            }
        }

        public bool IsEmpty 
        {
            get 
            {
                return pointer == -1;
            }
        }

        //public TransactionalStack<T> 
    }

    public class StackTransaction<T> : ITransaction
    {
        private TransactionalStack<T> stack;

        public void Push(T elem)
        {

        }

        public bool IsEmpty 
        {
            get 
            {
                return false;
            }
        }
    }


}
