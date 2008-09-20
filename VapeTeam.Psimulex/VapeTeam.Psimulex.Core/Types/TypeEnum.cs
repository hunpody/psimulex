using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// The types ordered by their priority.
    /// </summary>
    public enum TypeEnum
    {
        Undefined = 0,
        PropertyWrapper,
        Void,
        Boolean,
        Character,
        Integer,
        Decimal,
        String,
        Float,
        Iterator,
        Graph,
        Tree,
        BinaryTree,
        Node,
        Edge,
        PriorityQueue,
        Queue,
        Stack,
        Array,
        Matrix,
        List,
        LinkedList,
        Set,
        Timer,
        Pointer,
        Thread,
        FunctionPointerType,
        UserDefinedType,
        Null,
    }
}
