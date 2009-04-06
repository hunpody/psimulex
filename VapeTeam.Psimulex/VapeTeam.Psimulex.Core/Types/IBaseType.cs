using System;

namespace VapeTeam.Psimulex.Core.Types
{
    public interface IBaseType
    {
        /// <summary>
        /// The size of the object in the memory in bytes.
        /// </summary>
        int MemorySize { get; }

        /// <summary>
        /// The psimulex type of the value.
        /// </summary>
        TypeIdentifier Type { get; }

        /// <summary>
        /// The type of the class.
        /// </summary>
        /// <returns></returns>
        string GetTypeName();

        bool EqualsTo(IBaseType value);
        bool IsLessThan(BaseType value);
        bool NotEqualsTo(BaseType value);
        bool IsLessThanOrEqual(BaseType value);
        bool IsGreaterThan(BaseType value);
        bool IsGreaterThanOrEqual(BaseType value);

        /// <summary>
        /// Copies the value.
        /// </summary>
        /// <returns></returns>
        BaseType Clone();

        /// <summary>
        /// Performs the cloning but not doesn't return the clone.
        /// When pushing a value-by-ref (not a ReferencedValue!) then the clone method should return its value when it was pushed.
        /// Using PreClone it is possible.
        /// </summary>
        void PreClone();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BaseType ToReference();

        BaseType Dereference();
        void Assign(BaseType value);
        BaseType ConvertTo(TypeIdentifier type);
        void Add(BaseType value);
        void Subtract(BaseType value);
        void Negate();
        void Multiply(BaseType value);
        void Divide(BaseType value);
        void Power(BaseType value);
        void Modulo(BaseType value);
        object ToObject();
        long ToInt();
        int ToInt32();
        decimal ToDecimal();
        float ToFloat();
        bool ToBoolean();
        char ToChar();
        Array ToArray();
        List ToList();
        Set ToSet();
        Stack ToStack();
        Queue ToQueue();
        PriorityQueue ToPriorityQueue();
        LinkedList ToLinkedList();
        Graph ToGraph();
        GraphEdge ToGraphEdge();
        GraphNode ToGraphNode();
        Tree ToTree();
        BinaryTree ToBinaryTree();
        Iterator ToIterator();
        Null ToNull();
        event EventHandler<BaseType.ValueChangedEventArgs> Changed;
    }
}