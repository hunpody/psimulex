using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    class SystemHelper
    {
        internal static Process CreateMachineAndRunProgram(Program program)
        {
            return CreateMachineAndRunProgram(1, program);
        }

        internal static Process CreateMachineAndRunProgram(int processors, Program program)
        {
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(processors, 16);

            var process = machine.System.Load(program);

            machine.System.Run(process);

            return process;
        }

        internal static string CompileAndRun(Program program, int numberOfProcessors)
        {
            return CreateMachineAndRunProgram(numberOfProcessors, program).StandardOutput;
        }

        internal static string CompileAndRun(Program program)
        {
            return CompileAndRun(program, 1);
        }

        internal static string CompileAndRun(string source, int numberOfProcessors)
        {
            return CompileAndRun(CompilerProxy.Compile(source), numberOfProcessors);
        }

        internal static string CompileAndRun(string source)
        {
            return CompileAndRun(source, 1);
        }

        internal static Process CompileAndRunGetProcess(string source)
        {
            return CompileAndRunGetProcess(source, 1);
        }

        internal static Process CompileAndRunGetProcess(string source, int numberOfProcessors)
        {
            return CreateMachineAndRunProgram(numberOfProcessors, CompilerProxy.Compile(source));
        }
    }
}
