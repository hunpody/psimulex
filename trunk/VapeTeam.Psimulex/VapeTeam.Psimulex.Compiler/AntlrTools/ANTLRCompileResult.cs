using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.AntlrTools
{
    public class ANTLRCompileResult
    {
        public string ANTLRExceptionText { get; set; }
        public List<string> ANTLRErrorMessages { get; set; }
        public IPsiNode PsiNode { get; set; }
    }
}
