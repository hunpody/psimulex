using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    using Pair = Pair<NodeType, bool>;
    using ConfigSerializer = SerializationUtil<List<NodeTypeGroup>>;
    using NodeTypeGoupList = List<NodeTypeGroup>;

    [Serializable]
    public class Pair<TypeLeft,TypeRight>
    {
        public Pair()
        { }

        public Pair(TypeLeft left, TypeRight right)
        {
            Left = left;
            Right = right;
        }

        public TypeLeft Left { get; set; }
        public TypeRight Right { get; set; }
    }

    [Serializable]
    public class NodeTypeGroup
    {
        public string Name { get; set; }
        public List<Pair> NodeTypeList { get; set; }
    }

    /// <summary>
    /// Initialize, Savel, Load the syntax tree configuraton.
    /// </summary>
    public class SyntaxTreeConfiguration
    {
        public NodeTypeGoupList NodeTypeGroupList { get; set; }

        public SyntaxTreeConfiguration()
        {
            NodeTypeGroupList = new NodeTypeGoupList();
        }

        public SyntaxTreeConfiguration(string fileName)
            :   this()
        {
            Load(fileName);
        }

        /// <summary>
        /// Save the configuration to file.
        /// </summary>
        /// <param name="fileName">Save file name</param>
        public void Save(string fileName)
        {
            new ConfigSerializer().Save(NodeTypeGroupList, fileName);
        }

        /// <summary>
        /// Load the configuration from file.
        /// If file does not exist initialize the configuration with default daten.
        /// </summary>
        /// <param name="fileName">The file where the configuration is stored.</param>
        public void Load(string fileName)
        {
            if (!File.Exists(fileName))
                Initialize();
            else
                NodeTypeGroupList = new ConfigSerializer().Load(fileName);
        }


        /// <summary>
        /// Initialize the configuration
        /// </summary>
        public void Initialize()
        {
            NodeTypeGroupList = new NodeTypeGoupList
            {
                new NodeTypeGroup
                { 
                    Name = "High Level Node Types", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.CompilationUnit,  true),
                         new Pair(NodeType.SimpleProgram,  true),
                         new Pair(NodeType.MultiFunctionalProgram, true),
                         new Pair(NodeType.ImportDeclarations, true),
                         new Pair(NodeType.TypeDeclarations, true),
                         new Pair(NodeType.GlobalVariableDeclarations, true),
                         new Pair(NodeType.StructDeclaration, true),
                         new Pair(NodeType.MemberDeclaration, true),
                         new Pair(NodeType.FunctionDeclarations, true),
                         new Pair(NodeType.FunctionDeclaration, true),
                         new Pair(NodeType.FormalParameterList, true),
                         new Pair(NodeType.FormalParameter, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "LoopStatements", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.PForStatement, true),
                         new Pair(NodeType.ForStatement, true),
                         new Pair(NodeType.ForCondition, true),
                         new Pair(NodeType.ForInitialization, true),
                         new Pair(NodeType.ForUpdate, true),
    	                 new Pair(NodeType.DoStatement, true),
    	                 new Pair(NodeType.WhileStatement, true),
    	                 new Pair(NodeType.PForEachStatement, true),
                         new Pair(NodeType.ForEachStatement, true),
                         new Pair(NodeType.ForEachInitialization, true),
                         new Pair(NodeType.ForEachCollectionExpression, true),
    	                 new Pair(NodeType.LoopStatement, true),
                         new Pair(NodeType.LoopInitialization, true),
                         new Pair(NodeType.LoopLimit, true),
                         new Pair(NodeType.Condition, true),
                         new Pair(NodeType.Core, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "OtherStatements", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.Block, true),
                         new Pair(NodeType.Statement, true),                        
                         new Pair(NodeType.IfStatement, true),
                         new Pair(NodeType.IfBranch, true),
                         new Pair(NodeType.ElseIfBranches, true),
                         new Pair(NodeType.ConditionalBranch, true),
                         new Pair(NodeType.ElseBranch, true),                         
                         new Pair(NodeType.PDoStatement, true),
                         new Pair(NodeType.AsynStatement, true),
                         new Pair(NodeType.LockStatement, true),
                         new Pair(NodeType.ReturnStatement, true),
                         new Pair(NodeType.Return, true),
                         new Pair(NodeType.Break, true),                        
                         new Pair(NodeType.ExpressionStatement, true),
                         new Pair(NodeType.VariableDeclarationStatement, true),
                         new Pair(NodeType.VariableInitialization, true),
                         new Pair(NodeType.VariableDeclaration, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Literals", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.CharLiteral, true),
                         new Pair(NodeType.StringLiteral, true),
                         new Pair(NodeType.IntLiteral, true),
                         new Pair(NodeType.DecimalLiteral, true),
                         new Pair(NodeType.BoolLiteral, true),
                         new Pair(NodeType.NullLiteral, true),
                         new Pair(NodeType.InfinityLiteral, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Operators", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.AssignmentOp, true),
                         new Pair(NodeType.LogicalOrOp, true),
                         new Pair(NodeType.LogicalAndOp, true),
                         new Pair(NodeType.EqualityOp, true),
                         new Pair(NodeType.RelationOp, true),
                         new Pair(NodeType.AdditiveOp, true),
                         new Pair(NodeType.MultiplicativeOp, true),
                         new Pair(NodeType.UnaryOp, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Expressions", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.Expression, true),
                         new Pair(NodeType.Cast, true),
                         new Pair(NodeType.PrefixUnaryOperation, true),
                         new Pair(NodeType.Selector, true),
                         new Pair(NodeType.MemberSelect, true),
                         new Pair(NodeType.FunctionCall, true),
                         new Pair(NodeType.MemberFunctionCall, true),
                         new Pair(NodeType.Arguments, true),
                         new Pair(NodeType.Indexing, true),
                         new Pair(NodeType.Dimensions, true),
                         new Pair(NodeType.ConstantDimensions, true),
                         new Pair(NodeType.DimensionMarker, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Other", 
                    NodeTypeList = 
                    new List<Pair>
                    {
                         new Pair(NodeType.Identifier, true),
                         new Pair(NodeType.DataTypeName, true),
                         new Pair(NodeType.DataType, true),
                         new Pair(NodeType.Type, true),
                         new Pair(NodeType.Reference, true)
                    }
                }
            };
        }
    }
}
