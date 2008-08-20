using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The standard interface for a stack.
    /// It is not mainly intended to be "The Stack" for the libraries and common Simulex types.
    /// It is primarily used in the running environment.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        T Pop();
        T Top { get; }
        void Push(T item);
        void Clear();
        bool IsEmpty { get; }
    }
}
