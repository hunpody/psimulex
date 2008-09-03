using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    using InterruptEventHandler = EventHandler<InterruptRequestEventArgs>;
    using InterruptList = List<ProcessorInterruptInformation>;

    /// <summary>
    /// A virtual processor.
    /// Its operations can be delayed to emulate "hard" instructions.
    /// You can ask for an interrupt every N cycles if using a multitasking virtual operating system.
    /// </summary>
    public class Processor : HardwareElement
    {
        #region Interrupts

        private int _nextInterruptId;
        private int NextInterruptId 
        { 
            get 
            {
                return ++_nextInterruptId;
            }
        }

        private InterruptList processorInterruptList = new InterruptList();

        public void SetupPeriodicalTimeInterrupt(int cycles, InterruptEventHandler eventHandler)
        {
            processorInterruptList.Add(new ProcessorInterruptInformation
            {
                InterruptId = NextInterruptId,
                Frequence = cycles,
                EventHandler = eventHandler,
                LastInterruptTime = 0
            });
        }

        public event EventHandler<ProcessorInterruptRequestEventArgs> InterruptRequested;

        #endregion

        #region Cycles

        /// <summary>
        /// The numbers of cycles that has been spent since the processor is turned on.
        /// </summary>
        private int cycles;

        /// <summary>
        /// The number of cycles that has been spent in a non-idle state. (e.g. executing instructions)
        /// </summary>
        private int workingCycles;

        /// <summary>
        /// The reducent number that indicates how long this processor is doomed to deal with a certain operation.
        /// If this number becomes zero the Program Counter can be incremented.
        /// </summary>
        private int delayed;

        /// <summary>
        /// 
        /// </summary>
        public void Cycle()
        {
            if (RunningTask != null)
            {
                if (RunningTask.PC >= RunningTask.Program.CommandList.Count)
                {
                    RunningTask.State = ThreadStates.Finished;
                }

                if (RunningTask.State == ThreadStates.Running)
                {
                    RunningTask.System.CallingProcess = RunningTask.HostProcess;
                    int oldPC = RunningTask.PC;
                    RunningTask.Program[RunningTask.PC].Do(RunningTask);
                    // If there was no jump
                    if (oldPC == RunningTask.PC)
                    {
                        ++RunningTask.PC;
                    }
                }
            }
            ++cycles;

            // Checking if we should request an interrupt.
            processorInterruptList.Where(i => (cycles - i.LastInterruptTime) >= i.Frequence).ToList().ForEach(
                irq => irq.Interrupt(cycles));
        }
        
        #endregion


        public Thread RunningTask { get; set; }


        public Processor()
        {
        }
    }

    public class ProcessorInterruptRequestEventArgs : InterruptRequestEventArgs
    {
    }

    public class ProcessorList : List<Processor>
    {
    }
}
