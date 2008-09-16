using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    public interface IPsiVisitor
    {
        void VisitPsiNode(PsiNode node);

        void VisitSimpleProgramNode(SimpleProgramNode node);
        void VisitMultiFunctionalProgramNode(MultiFuncionalProgramNode node);
        void VisitImportDeclarationNode(ImportDeclarationNode node);
    }
}
