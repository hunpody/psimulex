﻿using System;
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
            return CreateMachineAndRunProgram(1, program);
        }

        internal static Process RunProgram(Machine machine, Program program)
        {
            var process = machine.System.Load(program);

            machine.System.Run(process);

            return process;
        }

        internal static Process CreateMachineAndRunProgram(int processors, Program program)
        {
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(processors, 1024);

            var process = machine.System.Load(program);

            machine.System.Run(process);

            return process;
        }
    }
}
