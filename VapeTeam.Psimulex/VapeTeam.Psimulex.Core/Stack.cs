using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A basic stack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IStack<T>
    {
        /// <summary>
        /// The representation.
        /// </summary>
        protected List<T> stack;

        /// <summary>
        /// The pointer to the top of the stack.
        /// </summary>
        protected int pointer;

        public Stack()
        {
            stack = new List<T>();
            pointer = -1;
        }

        public Stack(IEnumerable<T> items)
        {
            stack = new List<T>(items);
            pointer = stack.Count - 1;
        }

        public virtual void Push(T item)
        {
            stack.Add(item);
            ++pointer;
        }

        public virtual T Pop()
        {
            if (pointer < 0 || pointer >= stack.Count)
                throw new StackOverflowException();

            var item = stack[pointer];
            stack.RemoveAt(pointer);
            pointer = Math.Max(-1, pointer - 1);
            return item;
        }

        public Stack<T> Reverse()
        {
            return new Stack<T>(stack.ToArray().Reverse());
        }

        /// <summary>
        /// The number of elements in the stack.
        /// </summary>
        public int Count
        {
            get
            {
                return stack.Count;
            }
        }

        public virtual T Top
        {
            get
            {
                if (pointer < 0 || pointer >= stack.Count)
                    throw new StackOverflowException();
                return stack[pointer];
            }
        }

        public virtual bool IsEmpty
        {
            get
            {
                return pointer == -1;
            }
        }


        public virtual void Clear()
        {
            stack.Clear();
            pointer = -1;
        }
    }
}
