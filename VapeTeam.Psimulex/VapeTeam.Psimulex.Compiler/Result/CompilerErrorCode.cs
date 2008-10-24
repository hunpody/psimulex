﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public enum CompilerErrorCode
    {
        Custom,
        FormalParameterNameCollision,
        LocalVariableNameCollision,
        GlobalVariableNameCollision,
        FunctionCollison,
        ImportFileNotFound,
        NotImplemented
        // ...
    }

    public static class CompilerMessageText
    {
        public static string MesageText(CompilerErrorCode code)
        {
            return "";
        }
    }
}
