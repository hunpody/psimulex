using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.AntlrTools;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler
{
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        public CompileResult CompileResult { get; private set; }

        public Compiler()
        {
            CompileResult = new CompileResult();
        }

        /*
        #region Compiler TempMembers

        public List<string> ErrorMessages { get; set; }

        public string OutputString { get; set; }
        public string ExceptionMessages { get; set; }
        public global::Antlr.Runtime.Tree.CommonTree SyntaxTree { get; set; }

        #endregion

        #region ICompiler Members

        public CompileResult Compile(string source)
        {
            CompileResult result = new CompileResult();

            try
            {  
                var stream = new global::Antlr.Runtime.ANTLRStringStream(source);       
                PsimulexLexer lexer = new PsimulexLexer(stream);
                PsimulexParser p = new PsimulexParser(new global::Antlr.Runtime.CommonTokenStream(lexer));

                PsimulexParser.compilationUnit_return tree = p.compilationUnit();
                //PsimulexParser.block_return tree = p.block();
                //PsimulexParser.expression_return tree = p.expression();

                var treeAdaptor = p.TreeAdaptor;

                ErrorMessages = p.ErrorMessages;                

                OutputString = ((global::Antlr.Runtime.Tree.CommonTree)tree.Tree).ToStringTree();
                SyntaxTree = (global::Antlr.Runtime.Tree.CommonTree)tree.Tree;

                #region Added by pody, for temporary use (2008.09.21. 18:40)

                var visitor = new Psimulex.Compiler.AST.PsiCodeGeneratorVisitor(source, "teszt.psi");
                visitor.Visit(TreeConverter.FromCommonTreeToPsiNode(SyntaxTree) as AST.CompilationUnitNode);
                result.CompiledProgram = visitor.Program;
                result.CompilationUnitList = visitor.CompilationUnitList;
                #endregion

                #region Added by pody, for temporary use (2008.10.06. 11:48)

                visitor.Program.Program.AddFunctions(visitor.UserDefinedFunctionList);
                
                #endregion
            }
            catch (Exception e)
            {
                ExceptionMessages = e.ToString();
            }
            
            return result;
        }

        #endregion
        */

        public CompileResult Compile(string source, string sourceFileName)
        {
            return Compile(source, sourceFileName, new CommandPositionChanges(), new List<string>(),
                new List<CompilationUnit>(), new List<UserDefinedFunction>(), true);
        }

        public CompileResult Compile
            (
            string source, string sourceFileName,
            CommandPositionChanges commandPositionChanges,
            List<string> globalVariableList,
            List<CompilationUnit> compilationUnitList,
            List<UserDefinedFunction> userDefinedFunctionList
            )
        {
            return Compile(source, sourceFileName, commandPositionChanges,
                globalVariableList, compilationUnitList, userDefinedFunctionList, true);
        }

        public CompileResult Compile
            (
            string source, string sourceFileName,
            CommandPositionChanges commandPositionChanges,
            List<string> globalVariableList,
            List<CompilationUnit> compilationUnitList,
            List<UserDefinedFunction> userDefinedFunctionList,
            bool compileFuncVarTree
            )
        {
            CompileResult = new CompileResult();

            GenerateMicrolexCode(source, sourceFileName, commandPositionChanges,
                globalVariableList, compilationUnitList, userDefinedFunctionList);

            //if(compileFuncVarTree)
            //    CompileResult.PsiFunctionsVariablesNodeList = GenerateFuncVarTree(CompileResult.CompilationUnitList);

            return CompileResult;
        }

        public void GenerateMicrolexCode
            (
            string source, string sourceFileName,
            CommandPositionChanges commandPositionChanges,
            List<string> globalVariableList,
            List<CompilationUnit> compilationUnitList,
            List<UserDefinedFunction> userDefinedFunctionList
            )
        {
            var result = ANTLRCompiler.CompileCompilationUnit(source, sourceFileName);
            var visitor = new PsiCodeGeneratorVisitor
                (
                source, sourceFileName, result.ANTLRExceptionText, result.ANTLRErrorMessages,
                commandPositionChanges, globalVariableList, compilationUnitList, userDefinedFunctionList
                );

            try
            {
                visitor.Visit(result.PsiNode as CompilationUnitNode);
                visitor.CurrentCompilationUnit.PsiNodeSyntaxTree = result.PsiNode as CompilationUnitNode;
            }
            catch (Exception e)
            {
                visitor.CurrentCompilationUnit.CompilerMessages.Errors.Add(new Error
                {
                    MessageText = e.ToString(),
                    Interval = new Interval
                    {
                        FromLine = -1,
                        FromColumn = -1,
                        ToLine = -1,
                        ToColumn = -1,
                        FileName = sourceFileName
                    }
                });
            }

            CompileResult.CompiledProgram = visitor.Program;
            CompileResult.CommandPositionChanges = visitor.CommandPositionChanges;
            CompileResult.CompilationUnitList = visitor.CompilationUnitList;
            CompileResult.UserDefinedFunctionsList = visitor.UserDefinedFunctionList;
            
            CompileResult.CompiledProgram.AddFunctions(CompileResult.UserDefinedFunctionsList);
        }

        public List<PsiFunctionsVariablesNode> GenerateFuncVarTree(List<CompilationUnit> compilationUnitList)
        {
            List<PsiFunctionsVariablesNode> list = new List<PsiFunctionsVariablesNode>();

            foreach (var item in compilationUnitList)
            {
                var q = new PsiFunctionsVariablesQueryVisitor(item.Source, item.FileName);
                q.Visit(item.PsiNodeSyntaxTree as CompilationUnitNode);
                list.AddRange(q.PsiNodeList);
            }           

            return list;
        }
    }
}
