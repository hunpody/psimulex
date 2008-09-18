using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public interface IPsiVisitor
    {
        void Visit(PsiNode node);
        void Visit(XNode node);

        void Visit(CompilationUnitNode node);
        void Visit(SimpleProgramNode node);
        void Visit(MultiFuncionalProgramNode node);
        void Visit(ImportDeclarationNode node);
    }
}
