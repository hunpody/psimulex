using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class NodeTypeFactory : INodeTypeFactory
    {
        public NodeTypeFactory()
        { }

        public NodeType CreateNodeType(string s)
        {
            // String Szeritn szétválogatjuk és legyártjuk a nodeokat
            // ...

            return NodeType.X;
        }

        public NodeType CreateNodeType(int t)
        {
            NodeType type = NodeType.X;

            switch (t)
            {
                /*High Level Node Types*/
                case PsimulexLexer.COMPILATION_UNIT: type = NodeType.CompilationUnit; break;
                case PsimulexLexer.SIMPLE_PROGRAM: type = NodeType.SimpleProgram;  break;
                case PsimulexLexer.MULTY_FUNCTIONAL_PROGRAM: type = NodeType.MultiFunctionalProgram; break;
                case PsimulexLexer.IMPORT_DECLARATIONS: type = NodeType.ImportDeclarations; break;
                case PsimulexLexer.TYPE_DECLARATIONS: type = NodeType.TypeDeclarations; break;
                case PsimulexLexer.GLOBAL_VARIABLE_DECLARATIONS: type = NodeType.GlobalVariableDeclarations; break;
                case PsimulexLexer.STRUCTDEC: type = NodeType.StructDeclaration; break;
                case PsimulexLexer.MEMBERDEC: type = NodeType.MemberDeclaration; break;
                case PsimulexLexer.FUNCTION_DECLARATIONS: type = NodeType.FunctionDeclarations; break;
                case PsimulexLexer.FUNCDEC: type = NodeType.FunctionDeclaration; break;
                case PsimulexLexer.FORMALPARAM: type = NodeType.FormalParameter; break;
                case PsimulexLexer.BLOCK: type = NodeType.Block; break;
                case PsimulexLexer.VARINIT: type = NodeType.VariableInitialisation; break;
                case PsimulexLexer.VARDECLARE: type = NodeType.VariableDeclaration; break;

                /*ID*/
                case PsimulexLexer.Identifier: type = NodeType.Identifier; break;

                /*Literals*/
                case PsimulexLexer.CharacterLiteral: type = NodeType.CharLiteral; break;
                case PsimulexLexer.StringLiteral: type = NodeType.StringLiteral; break;
                case PsimulexLexer.IntegerLiteral: type = NodeType.IntLiteral; break;
                case PsimulexLexer.DecimalLiteral: type = NodeType.DecimalLiteral; break;
                case PsimulexLexer.BooleanLiteral: type = NodeType.BoolLiteral; break;
                case PsimulexLexer.NullLiteral: type = NodeType.NullLiteral; break;
                case PsimulexLexer.InfinityLiteral: type = NodeType.InfinityLiteral; break;

                /*Operators*/
                case PsimulexLexer.Assign:
                case PsimulexLexer.AssignAndAdd:
                case PsimulexLexer.AssignAndDivide:
                case PsimulexLexer.AssignAndModulo:
                case PsimulexLexer.AssignAndMultiply:
                case PsimulexLexer.AssignAndSubstract: type = NodeType.AssignmentOp; break;
                case PsimulexLexer.LogicalOr: type = NodeType.LogicalOrOp; break;
                case PsimulexLexer.LogicalAnd: type = NodeType.LogicalAndOp; break;
                case PsimulexLexer.RelEqual:
                case PsimulexLexer.RelNotEqual: type = NodeType.EqualityOp; break;
                case PsimulexLexer.RelGreaterThan:
                case PsimulexLexer.RelGreaterThanOrEqual:
                case PsimulexLexer.RelLessThan:
                case PsimulexLexer.RelLessThanOrEqual: type = NodeType.RelationOp; break;
                case PsimulexLexer.Plus:
                case PsimulexLexer.Minus: type = NodeType.AdditiveOp; break;
                case PsimulexLexer.Star:
                case PsimulexLexer.Divide:
                case PsimulexLexer.Modulo: type = NodeType.MultiplicativeOp; break;
                case PsimulexLexer.MinusMinus:
                case PsimulexLexer.PlusPlus:
                case PsimulexLexer.LogicalNot: type = NodeType.UnaryOp; break;

                /*Expression*/
                case PsimulexLexer.EXPRESSION: type = NodeType.Expression; break;
                case PsimulexLexer.ASSIGNMENT: type = NodeType.Assignment; break;
                case PsimulexLexer.LAMBDA_EXPRESSION: type = NodeType.LambdaExpression; break;
                case PsimulexLexer.LAMBDAPARAM: type = NodeType.LambdaParameter; break;
                case PsimulexLexer.LAMBDA_STATEMENT: type = NodeType.LambdaStatement; break;

                case PsimulexLexer.MEMBER_SELECT: type = NodeType.MemberSelect; break;
                case PsimulexLexer.MEMBER_FUNCTION_CALL: type = NodeType.FunctionCall; break;
                case PsimulexLexer.INDEXING: type = NodeType.Indexing; break;
                case PsimulexLexer.DIMS: type = NodeType.Dimensions; break;
                case PsimulexLexer.DIMMARKER: type = NodeType.DimensionMarker; break;
                
                /*Types*/
                case PsimulexLexer.Char:
                case PsimulexLexer.String:
                case PsimulexLexer.Int:
                case PsimulexLexer.Decimal:
                case PsimulexLexer.Bool:
                case PsimulexLexer.Void:

                case PsimulexLexer.Tree:
                case PsimulexLexer.BinTree:
                case PsimulexLexer.List:
                case PsimulexLexer.Stack:
                case PsimulexLexer.Set:
                case PsimulexLexer.Queue:
                case PsimulexLexer.PQueue: type = NodeType.DataTypeName; break;

                case PsimulexLexer.DATATYPE: type = NodeType.DataType; break;
                case PsimulexLexer.FUNCTIONPOINTERTYPE: type = NodeType.FunctionPointerType; break;
                case PsimulexLexer.TYPE: type = NodeType.Type; break;
                case PsimulexLexer.Reference: type = NodeType.Reference; break;

                default:
                    type = NodeType.X;
                    break;
            }

            // Int azaz típus szeritn szétválasztás.
            // ...

            return type;
        }
    }
}
