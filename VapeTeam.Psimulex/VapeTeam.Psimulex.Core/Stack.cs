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

        #region Events

        public class PopEventArgs : EventArgs
        {
            public T PoppedValue { get; set; }
        }

        public event EventHandler<PopEventArgs> BeingPopped;

        protected virtual void OnBeingPopped(T value)
        {
            if (BeingPopped != null)
            {
                BeingPopped(this, new Stack<T>.PopEventArgs { PoppedValue = value });
            }
        }

        #endregion

        public virtual T Pop()
        {
            if (pointer < 0 || pointer >= stack.Count)
                throw new Exceptions.IndexOutOfRangeException("Stack indexing was out of range.");

            var item = stack[pointer];
            OnBeingPopped(item);
            stack.RemoveAt(pointer);
            pointer = Math.Max(-1, pointer - 1);
            return item;
        }

        public virtual IEnumerable<T> Pop(int count)
        {
            if (pointer >= stack.Count || pointer + 1 < count)
                throw new Exceptions.IndexOutOfRangeException("Stack indexing was out of range.");

            List<T> items = new List<T>(count);

            for (int i = 0; i < count; ++i)
                items.Add(Pop());

            return items;
        }

        /// <summary>
        /// Returns the nth element from the bottom of the stack.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual T this[int index]
        {
            get
            {
                if (!(0 <= index && index <= Count - 1))
                {
                    throw new Exceptions.IndexOutOfRangeException("Stack indexing was out of range.");
                }

                return stack[index];
            }
            set
            {
                if (!(0 <= index && index <= Count - 1))
                {
                    throw new Exceptions.IndexOutOfRangeException("Stack indexing was out of range.");
                }

                stack[index] = value;
            }
        }

        public virtual Stack<T> Reverse()
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
                    throw new Exceptions.IndexOutOfRangeException("Stack indexing was out of range.");
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

        public override string ToString()
        {
            if (stack.Count == 0)
            {
                return "<Empty stack>";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = stack.Count - 1; i >= 0; --i)
                {
                    if (i != stack.Count - 1)
                        sb.AppendLine(",");
                    sb.Append(string.Format("[{0:000}]: {1}", stack.Count - 1 - i, stack[i]));
                }
                return sb.ToString();
            }
        }

        public IEnumerable<T> AsEnumerable()
        {
            return Reverse().stack;
        }
    }
}
