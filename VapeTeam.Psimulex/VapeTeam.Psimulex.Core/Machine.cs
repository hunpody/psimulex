using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A class that represents the virtual machine that is able to run programs.
    /// </summary>
    public class Machine
    {
        private List<CPU> cpus;

        private Scheduler scheduler;

        public Machine()
        {
            cpus = new List<CPU>();
            scheduler = new Scheduler();
        }

        /// <summary>
        /// Adds a processor to the machine.
        /// </summary>
        /// <param name="cpu"></param>
        public void AddProcessor(CPU cpu)
        {
            cpus.Add(cpu);
        }

        private int memorySize;

        /// <summary>
        /// The size of memory that is available in the machine.
        /// </summary>
        public int MemorySize
        {
            get
            {
                return memorySize;
            }
            set
            {
                memorySize = value;
            }
        }

        public void Run(Program program)
        {

        }

        public void Load(Program program)
        {

        }
    }
}
