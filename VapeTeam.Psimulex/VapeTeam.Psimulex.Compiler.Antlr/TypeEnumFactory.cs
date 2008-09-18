using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler.ANTLR
{
    public class TypeEnomFactory
    {
        public static TypeEnum CreateTypeEnum(string typeString)
        {
            typeString =  typeString.ToLower();

            switch (typeString)
            {
                /*Primitive Types*/
                case "char" : 
                case "character" : return TypeEnum.Character;
                case "string": return TypeEnum.String;
                case "int":
                case "integer": return TypeEnum.Integer;
                case "decimal": return TypeEnum.Decimal;
                case "bool":
                case "boolean": return TypeEnum.Boolean;
                case "void": return TypeEnum.Void;
                
                /*Built In Types*/
                case "tree": return TypeEnum.Tree;
                case "bintree": return TypeEnum.BinaryTree;
                case "set": return TypeEnum.Set;
                case "list": return TypeEnum.List;
                case "stack": return TypeEnum.Stack;
                case "queue": return TypeEnum.Queue;
                case "pqueue": return TypeEnum.PriorityQueue;
                case "graph": return TypeEnum.Graph;
                case "graphnode": return TypeEnum.Node;
                case "graphedge": return TypeEnum.Edge;
        
                /*Other*/
                case "thread": return TypeEnum.Thread;

                default: return TypeEnum.Undefined; // Struct
            }
        }
    }
}
