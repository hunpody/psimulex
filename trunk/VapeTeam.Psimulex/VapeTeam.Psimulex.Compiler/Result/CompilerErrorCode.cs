using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public enum CompilerErrorCode
    {
        Custom,

        FormalParameterNameCollision,
        StructAttributeNameCollision,
        LocalVariableNameCollision,
        GlobalVariableNameCollision,

        FunctionCollison,
        TypeCollision,

        UndefinedType,
        
        ImportFileNotFound,
        NotImplemented,
        NotSupported
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
