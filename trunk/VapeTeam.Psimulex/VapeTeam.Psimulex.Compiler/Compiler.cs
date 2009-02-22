using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Core;
using System.IO;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// Psimulex Compiler.
    /// Generate the Comand Object Array,
    /// Generate FunctionVariableTree.
    /// </summary>
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        public Compiler(IPsiNodeParser parser)
        {
            Parser = parser;
            CompileResult = new CompileResult();
        }

        #region Properties

        /// <summary>
        /// The result of the last compile.
        /// </summary>
        public CompileResult CompileResult { get; private set; }

        /// <summary>
        /// With this parser will be generated the output PsiNode tree
        /// </summary>
        public IPsiNodeParser Parser { get; set; }

        #endregion

        #region Members

        public CompileResult Compile(string source, string sourceFileName)
        {
            return Compile(source, sourceFileName, true, ProgramPart.CompilationUnit);
        }

        public CompileResult Compile(string source, string sourceFileName, bool compileFuncVarTree, ProgramPart part)
        {
            CompileResult = new CompileResult();

            string fullPath = Path.GetFullPath(sourceFileName);
            sourceFileName = Path.GetFileName(fullPath);

            // Data Transfer Object
            var dto = new CompilerDTO{ ProgramPath = Path.GetDirectoryName(fullPath) };            

            // Resolve Imports
            ResolveImports(source, sourceFileName, dto);

            // Finalize TypeIdentifiers
            FinalizeTypeIdentifiers(dto);

            // Analise and Compile all source file.
            foreach (var cu in dto.CompilationUnitList)
            {
                if (dto.CompilerMessages.AntlrErrors.Find(x => x.Interval.FileName == cu.FileName) == null)
                {
                    // Semantic analisis
                    Analise(cu, dto, part);

                    // Code generation
                    GenerateMicrolexCode(cu, dto, part);
                }
            }

            // Function Variable tree builder.
            if (compileFuncVarTree && part == ProgramPart.CompilationUnit)
                CompileResult.PsiFunctionsVariablesNodeList = GenerateFuncVarTree(dto.CompilationUnitList);

            // Finalise the overall result (CompilerDTO -> CompilerResult)
            FinaliseTheResult(dto);

            return CompileResult;
        }

        public void ResolveImports(string source, string sourceFileName, CompilerDTO dto)
        {
            // Parse
            try
            {
                Parser.Parse(source, sourceFileName, dto);
            }
            catch (Exception ex)
            {
                dto.CompilerMessages.AntlrErrors.Add(
                    new AntlrError
                    { 
                        Interval = new Interval() 
                        { FileName = sourceFileName }, 
                        MessageText = "Parser Error!"
                    });
            }            

            // Resolve Imports
            var resolver = new PsiImportResolverVisitor(dto.CompilationUnitList.Last<CompilationUnit>(), dto, this);
            var ast = dto.CompilationUnitList.Last<CompilationUnit>().PsiNodeSyntaxTree as CompilationUnitNode;
            if(ast != null)
                resolver.Visit(ast);
        }

        private void FinalizeTypeIdentifiers(CompilerDTO dto)
        {
            // Add TypeDescriptors to Program
            foreach (var td in dto.UserDefinedTypeInfoList)
                dto.Program.Program.AddUserDefinedType(td.Type.UserDefinedType);

            // Finalize Global variables TypeIdentifiers
            foreach (var global in dto.GlobalVariableInfoList)
            {
                if (global.Type.TypeEnum == TypeEnum.UserDefinedType)
                {
                    ITypeDescriptor td = dto.GetUserTypeDescriptor(global.Type.TypeName);
                    if (td == null)
                    {
                        dto.AddError(CompilerErrorCode.UndefinedType,
                            string.Format("Undefined type \"{0}\"!", global.Type.TypeName),
                            global.NodeValueInfo, global.FileName);

                        // Set Type to undefined !
                        global.Type.TypeEnum = TypeEnum.Undefined;
                    }
                    else
                    {
                        global.Type.UserDefinedType = td;
                    }
                }
            }

            // Finalize Function parameter and return TypeIdentifiers
            foreach (var func in dto.UserDefinedFunctionInfoList)
            {
                // Return Type
                if (func.Function.ReturnValueType.Type.TypeEnum == TypeEnum.UserDefinedType)
                {
                    ITypeDescriptor td = dto.GetUserTypeDescriptor(func.Function.ReturnValueType.Type.TypeName);
                    if (td == null)
                    {
                        dto.AddError(CompilerErrorCode.UndefinedType,
                            string.Format("Undefined type \"{0}\"!", func.Function.ReturnValueType.Type.TypeName),
                            func.NodeValueInfo, func.FileName);

                        // Set Type to undefined !
                        func.Function.ReturnValueType.Type.TypeEnum = TypeEnum.Undefined;
                    }
                    else
                    {
                        func.Function.ReturnValueType.Type.UserDefinedType = td;
                    }
                }

                // Parameter Types
                foreach (var param in func.Function.Parameters)
                {
                    if (param.Type.TypeEnum == TypeEnum.UserDefinedType)
                    {
                        ITypeDescriptor td = dto.GetUserTypeDescriptor(param.Type.TypeName);
                        if (td == null)
                        {
                            dto.AddError(CompilerErrorCode.UndefinedType, string.Format(
                                "Undefined type \"{0}\" in function \"{1}\" at the \"{2}\" parameter!",
                                param.Type.TypeName, func.Name, param.Name),
                                func.NodeValueInfo, func.FileName);

                            // Set Type to undefined !
                            param.Type.TypeEnum = TypeEnum.Undefined;
                        }
                        else
                        {
                            param.Type.UserDefinedType = td;
                        }
                    }
                }
            }

            // Finalize User defined type memeber TypeIdentifiers
            // If this will be allowed !
            // UDT in UDT not allowed yet !
            foreach (var type in dto.UserDefinedTypeInfoList)
            {
                var udtd = type.Type.UserDefinedType as UserDefinedTypeDescriptor;
                if (udtd == null)
                {
                    // Error ! Not an user defined type.
                }
                else
                {
                    foreach (var attr in udtd.Attributes)
                    {
                        if (attr.Descriptor.Type.TypeEnum == TypeEnum.UserDefinedType)
                        {
                            ITypeDescriptor td = dto.GetUserTypeDescriptor(attr.Descriptor.Type.TypeName);
                            if (td == null)
                            {
                                dto.AddError(CompilerErrorCode.UndefinedType, string.Format(
                                    "Undefined type \"{0}\" in User Defined Type \"{1}\" at Memeber \"{2}\"!",
                                    attr.Descriptor.Type.TypeName, type.Name, attr.Descriptor.Name),
                                    type.NodeValueInfo, type.FileName);

                                // Set Type to undefined !
                                attr.Descriptor.Type.TypeEnum = TypeEnum.Undefined;
                            }
                            else
                            {
                                attr.Descriptor.Type.UserDefinedType = td;
                            }
                        }
                    }
                }
            }
        }

        private void Analise(CompilationUnit cu, CompilerDTO dto, ProgramPart part)
        {
            if (part == ProgramPart.CompilationUnit)
                new PsiSemanticAnaliserVisitor(cu, dto).Visit(cu.PsiNodeSyntaxTree as CompilationUnitNode);
            //else What To Do ?
        }

        private void GenerateMicrolexCode(CompilationUnit cu, CompilerDTO dto, ProgramPart part)
        {
            var visitor = new PsiCodeGeneratorVisitor(cu, dto);

            try
            {
                switch (part)
                {
                    case ProgramPart.CompilationUnit:
                        visitor.Visit(cu.PsiNodeSyntaxTree as CompilationUnitNode);
                        break;
                    case ProgramPart.Statement:
                        var node = new StatementNode();
                        node.Init();
                        node.Type = NodeType.Statement;

                        node.Add(cu.PsiNodeSyntaxTree);
                        visitor.Visit(node);
                        break;
                    default:
                        visitor.Visit(cu.PsiNodeSyntaxTree as CompilationUnitNode);
                        break;
                }

                //visitor.CurrentCompilationUnit.PsiNodeSyntaxTree = result.PsiNode as CompilationUnitNode;

            }
            catch (Exception e)
            {
                dto.CompilerMessages.Errors.Add(new Error
                {
                    MessageText = e.ToString(),
                    Interval = new Interval { FileName = cu.FileName }
                });
            }            
        }

        private List<PsiFunctionsVariablesNode> GenerateFuncVarTree(List<CompilationUnit> compilationUnitList)
        {
            List<PsiFunctionsVariablesNode> list = new List<PsiFunctionsVariablesNode>();

            foreach (var item in compilationUnitList)
            {
                if (item.PsiNodeSyntaxTree != null)
                {
                    var q = new PsiFunctionsVariablesQueryVisitor(item.Source, item.FileName);
                    q.Visit(item.PsiNodeSyntaxTree as CompilationUnitNode);
                    list.AddRange(q.PsiNodeList);
                }
            }           

            return list;
        }

        /// <summary>
        /// The last steps on the result befor return.
        /// </summary>
        private void FinaliseTheResult(CompilerDTO dto)
        {
            // Add functions to the program
            dto.UserDefinedFunctionInfoList.ForEach(func => dto.Program.Program.AddFunction(func.Function));

            CompileResult.CompilerMessages = dto.CompilerMessages;

            CompileResult.CompiledProgram = dto.Program;
            CompileResult.CompiledProgram.CommandPositionProvider =
                new SimpleCommandPositionProvider(dto.CommandPositionChanges);
            CompileResult.ProgramPath = dto.ProgramPath;

            CompileResult.CommandPositionChanges = dto.CommandPositionChanges;
            CompileResult.CompilationUnitList = dto.CompilationUnitList;

            CompileResult.UserDefinedFunctionInfoList = dto.UserDefinedFunctionInfoList;
            CompileResult.UserDefinedTypeInfoList = dto.UserDefinedTypeInfoList;
            CompileResult.GlobalVariableInfoList = dto.GlobalVariableInfoList;
        }

        #endregion
    }
}
