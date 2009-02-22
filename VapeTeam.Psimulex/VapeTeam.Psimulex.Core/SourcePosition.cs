using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// Locates a position in the source code.
    /// </summary>
    public class SourcePosition
    {
        public string FileName { get; set; }
        public string FunctionName { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
    }
}
