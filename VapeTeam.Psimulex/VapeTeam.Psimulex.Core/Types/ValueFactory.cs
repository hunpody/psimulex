using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class ValueFactory
    {
        /// <summary>
        /// Creates a Psimulex value object from the .NET object. It wraps .NET objects into Psimulex ones.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BaseType Create(object value)
        {
            if (value == null)
            {
                return new Null();
            }
            else if (value.GetType() == typeof(BaseType) || value.GetType().IsSubclassOf(typeof(BaseType)))
            {
                return (BaseType)value;
            }
            else if (value.GetType() == typeof(long))
            {
                return new Integer((long)value);
            }
            else if (value.GetType() == typeof(int))
            {
                long x = (int)value;
                return new Integer(x);
            }
            else if (value.GetType() == typeof(string))
            {
                return new String((string)value);
            }
            else if (value.GetType() == typeof(bool))
            {
                return new Boolean((bool)value);
            }
            else if (value.GetType() == typeof(decimal))
            {
                return new Decimal((decimal)value);
            }
            else if (value.GetType() == typeof(float))
            {
                return new Float((float)value);
            }
            else if (value.GetType() == typeof(char))
            {
                return new Character((char)value);
            }
            else if (value.GetType() == typeof(VapeTeam.Psimulex.Core.Thread))
            {
                return new VapeTeam.Psimulex.Core.Types.Thread((VapeTeam.Psimulex.Core.Thread)value);
            }
            else
            {
                return new String(value.ToString());
            }
        }

        private static bool TypeEquals(Type type, Type type2)
        {
            return type.Name.StartsWith(type2.Name);
        }

        /// <summary>
        /// Transforms a Psimulex type to its closest .NET equivalent.
        /// It is mainly utilized by the SystemCall mechanism.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object TransformToDotnetType(BaseType value, Type type)
        {
            if (TypeEquals(type, typeof(BaseType)))
            {
                return value;
            }
            else if (type.IsSubclassOf(typeof(BaseType)))
            {
                return value.ConvertTo(GetTypeEnumOfType(type));
            }
            else if (TypeEquals(type, typeof(string)))
            {
                return value.ToString();
            }
            else if (TypeEquals(type, typeof(int)))
            {
                return (int) value.ToInt();
            }
            else if (TypeEquals(type, typeof(long)))
            {
                return value.ToInt();
            }
            else if (TypeEquals(type, typeof(decimal)))
            {
                return value.ToDecimal();
            }
            else if (TypeEquals(type, typeof(float)))
            {
                return value.ToFloat();
            }
            else if (TypeEquals(type, typeof(bool)))
            {
                return value.ToBoolean();
            }
            else if (TypeEquals(type, typeof(char)))
            {
                return value.ToChar();
            }
            else
                return null;
        }

        private static TypeEnum GetTypeEnumOfType(Type type)
        {
            if (type == typeof(Integer))
                return TypeEnum.Integer;
            if (type == typeof(Character))
                return TypeEnum.Character;
            if (type == typeof(Decimal))
                return TypeEnum.Decimal;
            if (type == typeof(Array))
                return TypeEnum.Array;
            if (type == typeof(BinaryTree))
                return TypeEnum.BinaryTree;
            if (type == typeof(Boolean))
                return TypeEnum.Boolean;
            if (type == typeof(Float))
                return TypeEnum.Float;
            if (type == typeof(Graph))
                return TypeEnum.Graph;
            if (type == typeof(GraphEdge))
                return TypeEnum.Edge;
            if (type == typeof(GraphNode))
                return TypeEnum.Node;
            if (type == typeof(Point))
                return TypeEnum.Point;
            if (type == typeof(Iterator))
                return TypeEnum.Iterator;
            if (type == typeof(LinkedList))
                return TypeEnum.LinkedList;
            if (type == typeof(List))
                return TypeEnum.List;
            if (type == typeof(Null))
                return TypeEnum.Null;
            if (type == typeof(PriorityQueue))
                return TypeEnum.PriorityQueue;
            if (type == typeof(Queue))
                return TypeEnum.Queue;
            if (type == typeof(Set))
                return TypeEnum.Set;
            if (type == typeof(Stack))
                return TypeEnum.Stack;
            if (type == typeof(String))
                return TypeEnum.String;
            if (type == typeof(Thread))
                return TypeEnum.Thread;
            if (type == typeof(Tree))
                return TypeEnum.Tree;

            throw new Exceptions.PsimulexCoreException(string.Format("Cannot get the Psimulex type of the CLR type \"{0}\"", type));

        }

        /// <summary>
        /// Transforms an array of Psimulex types to their closest .NET equivalent.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="targetTypes"></param>
        /// <returns></returns>
        public static object[] TransformBaseTypeArrayToDotnetType(IEnumerable<BaseType> parameters, Type[] targetTypes)
        {
            object[] objArray = new object[parameters.Count()];
            int objArrayPointer = 0;
            foreach (var par in parameters)
            {
                objArray[objArrayPointer] = TransformToDotnetType(par, targetTypes[objArrayPointer]);
                ++objArrayPointer;
            }

            return objArray;
        }

        /// <summary>
        /// Creates a BaseType value from the given typeEnum.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static BaseType CreateValue(TypeIdentifier type)
        {
            switch (type.TypeEnum)
            {
                // Primitive Types
                case TypeEnum.Void:
                    return null;
                case TypeEnum.Integer:
                    return new Integer();
                case TypeEnum.Character:
                    return new Character();
                case TypeEnum.String:
                    return new String();
                case TypeEnum.Decimal:
                    return new Decimal();
                case TypeEnum.Float:
                    return new Float();
                case TypeEnum.Boolean:
                    return new Boolean();

                // Complex Types
                case TypeEnum.Array:
                    return new Array(type.GenericType, type.Dimensions[0]);
                case TypeEnum.List:
                    return new List();
                case TypeEnum.Set:
                    return new Set();
                case TypeEnum.Stack:
                    return new Stack();
                case TypeEnum.Queue:
                    return new Queue();
                case TypeEnum.PriorityQueue:
                    return new PriorityQueue();

                case TypeEnum.Point:
                    return new Point();

                //case TypeEnum.Iterator:
                //    return new Iterator(

                case TypeEnum.Tree:
                    return new Tree();
                case TypeEnum.BinaryTree:
                    return new BinaryTree();
                case TypeEnum.Null:
                    return new Null();                    
                default:
                    throw new Exceptions.PsimulexCoreException(string.Format("Cannot create value of type {0}.", type));
            }
        }

        /// <summary>
        /// Converts a basetype value to the given type.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        public static BaseType Convert(BaseType value, TypeIdentifier targetType)
        {
            if (targetType.TypeEnum == TypeEnum.Undefined || targetType == value.Type)
            {
                return value;
            }
            var target = CreateValue(targetType);
            target.Assign(value);
            return target;
        }


        /// <summary>
        /// Creates a BaseType value from the type name string.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static BaseType CreateValue(string type)
        {
            object parsedType = Enum.Parse(typeof(TypeEnum), type);
            if (parsedType != null)
            {
                return CreateValue((TypeEnum)parsedType);
            }
            else
            {
                // throw ex?
                return null;
            }
        }

        //public static void ConvertToHigher(BaseType a, BaseType b, out BaseType convertedA, out BaseType convertedB)
        //{          

        //}
    }
}
