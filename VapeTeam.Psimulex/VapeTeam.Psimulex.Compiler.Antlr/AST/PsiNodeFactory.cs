using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    public class PsiNodeFactory : IPsiNodeFactory
    {
        public IPsiNode CreateNode(NodeType type, string value,  string viewComment, IPsiNode parent, List<IPsiNode> children)
        {
            // Itt kell egy jó nagy switch
            // ...
            // Fontos, hogy az IsVirtualt itt el kell dönteni !
            // Itt lehet még view Commenteket adni ... Vagy törölni ezt a property-t.

            IPsiNode node = new PsiNode(parent, value, type, false, "");

            switch (type)
            {
                case NodeType.SimpleProgram:
                    break;
                case NodeType.MultiFunctionalProgram:
                    break;
                case NodeType.ImportDeclarations:
                    break;
                case NodeType.TypeDeclarations:
                    break;
                case NodeType.StructDeclaration:
                    break;
                case NodeType.GlobalVariableDeclarations:
                    break;
                case NodeType.MemberDeclaration:
                    break;
                case NodeType.FunctionDeclarations:
                    break;
                case NodeType.FunctionDeclaration:
                    break;
                case NodeType.FormalParameter:
                    break;
                case NodeType.Block:
                    break;
                case NodeType.VariableInitialisation:
                    break;
                case NodeType.VariableDeclaration:
                    break;
                case NodeType.AssignmentOp:
                    break;
                case NodeType.LogicalOrOp:
                    break;
                case NodeType.LogicalAndOp:
                    break;
                case NodeType.EqualityOp:
                    break;
                case NodeType.RelationOp:
                    break;
                case NodeType.AdditiveOp:
                    break;
                case NodeType.MultiplicativeOp:
                    break;
                case NodeType.UnaryOp:
                    break;
                case NodeType.Expression:
                    break;
                case NodeType.Assignment:
                    break;
                case NodeType.LambdaExpression:
                    break;
                case NodeType.LambdaParameter:
                    break;
                case NodeType.LambdaStatement:
                    break;
                case NodeType.MemberSelect:
                    break;
                case NodeType.MemberFunctionCall:
                    break;
                case NodeType.FunctionCall:
                    break;
                case NodeType.Indexing:
                    break;
                case NodeType.Dimensions:
                    break;
                case NodeType.DimensionMarker:
                    break;
                case NodeType.Identifier:
                    break;
                case NodeType.CharLiteral:
                    break;
                case NodeType.StringLiteral:
                    break;
                case NodeType.IntLiteral:
                    break;
                case NodeType.DecimalLiteral:
                    break;
                case NodeType.BoolLiteral:
                    break;
                case NodeType.NullLiteral:
                    break;
                case NodeType.InfinityLiteral:
                    break;
                case NodeType.DataTypeName:
                    break;
                case NodeType.DataType:
                    break;
                case NodeType.FunctionPointerType:
                    break;
                case NodeType.Type:
                    break;
                case NodeType.Reference:
                    break;

                case NodeType.X:
                default:
                    node = new PsiNode(parent, value, type, false, "");
                    break;
            }

            return node;
        }

        public IPsiNode CreateNode(NodeType type)
        {
            return CreateNode(type, "", "", null, null);
        }

        public IPsiNode CreateNode(NodeType type, string value)
        {
            return CreateNode(type, value, "", null, null);
        }
    }
}
