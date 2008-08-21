using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Tests.Helpers
{
    class SystemHelper
    {
        internal static Process CreateMachineAndRunProgram(Program program)
        {
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(1, 16);

            var process = machine.System.Load(program);

            machine.System.Run(process);

            return process;
        }
    }
}
