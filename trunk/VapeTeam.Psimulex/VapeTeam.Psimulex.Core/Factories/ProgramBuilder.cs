using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core.Factories
{
    /// <summary>
    /// A builder class for creating programs from basic commands.
    /// </summary>
    public class ProgramBuilder
    {
        public Program Program { get; private set; }

        public ProgramBuilder()
        {
            Program = new Program();
        }

        public ProgramBuilder Add(ICommand command)
        {
            Program.CommandList.Add(command);
            return this;
        }

        public ProgramBuilder Add(params ICommand[] commands)
        {
            foreach (var command in commands)
            {
                Program.CommandList.Add(command);
            }
            return this;
        }

        public static ProgramBuilder Create()
        {
            return new ProgramBuilder();
        }

        public static implicit operator Program(ProgramBuilder builder)
        {
            return builder.Program;
        }

        public override string ToString()
        {
            return Program.ToString();
        }
    }
}
