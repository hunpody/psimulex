﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler
{
    public class CompileResult
    {
        public Program CompiledProgram { get; set; }
        public string SourceText { get; set; }
    }
}
