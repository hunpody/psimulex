using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The state represent the current environment.
    /// A state gets pushed if the interpreter performs a call.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Program counter.
        /// </summary>
        public int PC { get; private set; }

        /// <summary>
        /// Stack pointer.
        /// </summary>
        public int SP { get; private set; }
        public VariableLocator VariableMap { get; private set; }

        public State(int pc, int sp, VariableLocator variableMap)
        {
            this.PC = pc;
            this.SP = sp;
            this.VariableMap = variableMap;
        }

        public override string ToString()
        {
            return string.Format("PC={0}, SP={1}, variables={2}", PC, SP, VariableMap);
        }
    }
}
