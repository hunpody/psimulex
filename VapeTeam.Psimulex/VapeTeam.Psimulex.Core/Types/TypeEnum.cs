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

        /*Primitive Types*/
        Character,
        String,
        Integer,
        Decimal,
        Boolean, 
     
        Void,
        
        /*Built In Types*/
        Tree,
        BinaryTree,
        Set,
        List,
        Stack,
        Queue,
    	PriorityQueue,
        Graph,
        Node,
        Edge,
        Float,
        Iterator,
        Timer,
        Pointer,
        Null,

        /*Other*/               
        Array,
        Matrix,
        Thread,
        FunctionPointerType,
        UserDefinedType,
    }
}
