using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class MachineBuilder
    {
        private static MachineBuilder _instance;
        public static MachineBuilder Instance
        {
            get
            {
                // Read machineBuilder from configuration file if it is needed
                if (_instance == null)
                    _instance = new MachineBuilder();
                return _instance;
            }
        }
        public Machine CreateMachine(int numberOfProcessors, int sizeOfMemory)
        {
            Machine machine = new Machine();
            for (int i=0; i<numberOfProcessors; ++i)
                machine.AddProcessor(new Processor());
            machine.MemorySize = sizeOfMemory;
            machine.System = OperatingSystemBuilder.CreateOSWithRoundRobin();
            machine.System.Setup(machine);
            //Memory.Instance = machine.Memory;
            return machine;
        }
    }
}
