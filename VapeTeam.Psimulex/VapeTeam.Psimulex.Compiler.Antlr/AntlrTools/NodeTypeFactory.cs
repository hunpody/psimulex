using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.AntlrTools
{
    public class NodeTypeFactory
    {
        public static NodeType CreateNodeType(int t)
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
                case PsimulexLexer.FORMAL_PARAMETER_LIST: type = NodeType.FormalParameterList; break;
                case PsimulexLexer.FORMAL_PARAMETER: type = NodeType.FormalParameter; break;

                /*Program Structures*/
                case PsimulexLexer.BLOCK: type = NodeType.Block; break;
                case PsimulexLexer.STATEMENT: type = NodeType.Statement; break;
                
                case PsimulexLexer.IFSTATEMENT: type = NodeType.IfStatement; break;
                case PsimulexLexer.IFBRANCH: type = NodeType.IfBranch; break;
                case PsimulexLexer.ELSEIFBRANCHES: type = NodeType.ElseIfBranches; break;
                case PsimulexLexer.CONDITIONALBRANCH: type = NodeType.ConditionalBranch; break;
                case PsimulexLexer.ELSEBRANCH: type = NodeType.ElseBranch; break;

                case PsimulexLexer.PFORSTATEMENT: type = NodeType.PForStatement; break;
                case PsimulexLexer.FORSTATEMENT: type = NodeType.ForStatement; break;
                case PsimulexLexer.FORCONDITION: type = NodeType.ForCondition; break;
                case PsimulexLexer.FORINIT: type = NodeType.ForInitialization; break;
                case PsimulexLexer.FORUPDATE: type = NodeType.ForUpdate; break;

    	        case PsimulexLexer.DOSTATEMENT: type = NodeType.DoStatement; break;

    	        case PsimulexLexer.WHILESTATEMENT: type = NodeType.WhileStatement; break;

    	        case PsimulexLexer.PFOREACHSTATEMENT: type = NodeType.PForEachStatement; break;
                case PsimulexLexer.FOREACHSTATEMENT: type = NodeType.ForEachStatement; break;
                case PsimulexLexer.FOREACHINIT: type = NodeType.ForEachInitialization; break;
                case PsimulexLexer.FOREACHCOLLECTION: type = NodeType.ForEachCollectionExpression; break;

    	        case PsimulexLexer.LOOPSTATEMENT: type = NodeType.LoopStatement; break;
                case PsimulexLexer.LOOPINIT: type = NodeType.LoopInitialization; break;
                case PsimulexLexer.LOOPLIMIT: type = NodeType.LoopLimit; break;

                case PsimulexLexer.CONDITION: type = NodeType.Condition; break;
                case PsimulexLexer.CORE: type = NodeType.Core; break;

                case PsimulexLexer.PDOSTATEMENT: type = NodeType.PDoStatement; break;
                case PsimulexLexer.ASYNCSTATEMENT: type = NodeType.AsynStatement; break;
                case PsimulexLexer.LOCKSTATEMENT: type = NodeType.LockStatement; break;

                case PsimulexLexer.RETURN_STATEMENT: type = NodeType.ReturnStatement; break;
                case PsimulexLexer.Return: type = NodeType.Return; break;
                case PsimulexLexer.Break: type = NodeType.Break; break;
                //case PsimulexLexer.Continue: type = NodeType.Continue; break;
                case PsimulexLexer.EXPRESSION_STATEMENT: type = NodeType.ExpressionStatement; break;

                case PsimulexLexer.VARIABLE_DECLARATION_STATEMENT: type = NodeType.VariableDeclarationStatement; break;
                case PsimulexLexer.VARINIT: type = NodeType.VariableInitialization; break;
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
                case PsimulexLexer.CAST: type = NodeType.Cast; break;
                case PsimulexLexer.PREFIXOP: type = NodeType.PrefixUnaryOperation; break;
                /*
                case PsimulexLexer.LAMBDA_EXPRESSION: type = NodeType.LambdaExpression; break;
                case PsimulexLexer.LAMBDAPARAM: type = NodeType.LambdaParameter; break;
                case PsimulexLexer.LAMBDA_STATEMENT: type = NodeType.LambdaStatement; break;
                */

                case PsimulexLexer.SELECTOR: type = NodeType.Selector; break;
                case PsimulexLexer.MEMBER_SELECT: type = NodeType.MemberSelect; break;
                case PsimulexLexer.FUNCTION_CALL: type = NodeType.FunctionCall; break;
                case PsimulexLexer.MEMBER_FUNCTION_CALL: type = NodeType.MemberFunctionCall; break;
                case PsimulexLexer.ARGUMENTS: type = NodeType.Arguments; break;
                case PsimulexLexer.INDEXING: type = NodeType.Indexing; break;
                case PsimulexLexer.ARRAY_INITIALIZER: type = NodeType.ArrayInitializer; break;
                case PsimulexLexer.COLLECTION_INITIALIZER: type = NodeType.CollectionInitializer; break;
                
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

                case PsimulexLexer.DIMMARKER: type = NodeType.DimensionMarker; break;
                case PsimulexLexer.DATATYPE: type = NodeType.DataType; break;
                /*
                case PsimulexLexer.FUNCTIONPOINTERTYPE: type = NodeType.FunctionPointerType; break;
                */
                case PsimulexLexer.TYPE: type = NodeType.Type; break;
                case PsimulexLexer.Reference: type = NodeType.Reference; break;

                default:
                    type = NodeType.X;
                    break;
            }

            return type;
        }
    }
}
