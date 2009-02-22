using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core
{
    public class StackTrace
    {
        public class StackElement
        {
            public SourcePosition Position { get; set; }
            public ICommand Command { get; set; }
            public int PC { get; set; }
        }

        public List<StackElement> Trace { get; private set; }

        public StackTrace()
        {
            Trace = new List<StackElement>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var elem in Trace)
            {
                if (elem.Position == default(SourcePosition))
                {
                    sb.AppendLine(string.Format("at non-user code: @{0}",
                        elem.PC));
                }
                else
                {
                    sb.AppendLine(string.Format("at {0}:{1}:{2} (@{3})",
                        elem.Position.FileName, elem.Position.FunctionName, elem.Position.Line, elem.PC));
                }
            }
            return sb.ToString();
        }
    }
}
