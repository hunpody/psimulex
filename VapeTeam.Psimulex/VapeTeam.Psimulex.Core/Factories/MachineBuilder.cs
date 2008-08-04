using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class MachineBuilder
    {
        public Machine CreateMachine(int numberOfProcessors, int sizeOfMemory)
        {
            Machine machine = new Machine();
            for (int i=0; i<numberOfProcessors; ++i)
                machine.AddProcessor(new CPU());
            machine.MemorySize = sizeOfMemory;
            return machine;
        }
    }
}
