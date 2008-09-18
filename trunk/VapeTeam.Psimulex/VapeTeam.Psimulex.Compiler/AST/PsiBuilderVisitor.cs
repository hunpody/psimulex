using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class PsiBuilderVisitor : IPsiVisitor
    {

        #region IPsiVisitor Members

        public void Visit(PsiNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(XNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(CompilationUnitNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(SimpleProgramNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MultiFuncionalProgramNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ImportDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
