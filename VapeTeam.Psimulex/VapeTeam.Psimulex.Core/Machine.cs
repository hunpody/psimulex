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
        private ProcessorList processors;

        public ProcessorList Processors
        {
            get
            {
                return processors;
            }
        }

        public OperatingSystem System { get; set; }

        public Machine()
        {
            processors = new ProcessorList();
            //System = Factories.OperatingSystemBuilder.CreateOSWithRoundRobin();
            //System.Setup(this);
            //scheduler = new IScheduler();
        }

        /// <summary>
        /// Adds a processor to the machine.
        /// </summary>
        /// <param name="cpu"></param>
        public void AddProcessor(Processor processor)
        {
            processors.Add(processor);
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

        public void Install(OperatingSystem operatingSystem)
        {
            System = operatingSystem;
            operatingSystem.Setup(this);
        }

        public void Run()
        {
        }

        public string ScreenContent { get; internal set; }
    }
}
