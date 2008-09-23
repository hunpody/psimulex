using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// Type of PsiAST Node
    /// </summary>
    public enum NodeType
    {
        /*Undefined*/
        X,

        /*High Level Node Types*/
        CompilationUnit,
        SimpleProgram,
        MultiFunctionalProgram,
        ImportDeclarations,
        TypeDeclarations,
        StructDeclaration,
        GlobalVariableDeclarations,
        MemberDeclaration,
        FunctionDeclarations,
        FunctionDeclaration,
        FormalParameterList,
        FormalParameter,
        Block,
        Statement,

        VariableInitialisation,
        VariableDeclaration,        	

        /*Operators*/
        AssignmentOp,
        LogicalOrOp,
        LogicalAndOp,
        EqualityOp,
        RelationOp,
        AdditiveOp,
        MultiplicativeOp,
        UnaryOp,

        /*Expressions*/
        Expression,
        Cast,
        PrefixUnaryOperation,
        /*
        LambdaExpression,
        LambdaParameter,
        LambdaStatement,
        */

        MemberSelect,
        MemberFunctionCall,        
        FunctionCall,
        Arguments,
        Indexing,
        ConstantDimensions,
        Dimensions,
        DimensionMarker,        

        /*ID*/
        Identifier,

        /*Literals*/
        CharLiteral,
        StringLiteral,
        IntLiteral,
        DecimalLiteral,
        BoolLiteral,
        NullLiteral,
        InfinityLiteral,

        /*Types*/
        DataTypeName,
        DataType,
        FunctionPointerType,
        Type,
        Reference,
    }
}
