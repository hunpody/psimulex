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
        /// Makes a CPU cycle.
        /// </summary>
        public void Cycle()
        {
            // If there is a thread to execute
            if (CurrentThread != null)
            {
                // Checks if it has ended
                if (!CurrentThread.CanExecuteNext)
                {
                    CurrentThread.State = ThreadStates.Finished;
                }

                if (CurrentThread.State == ThreadStates.Running)
                {
                    CurrentThread.System.CallingThread = CurrentThread;
                    int oldPC = CurrentThread.PC;

                    // The logging should be optional, so read the logging policy from config and uncomment this line.
                    //Logger.Log(CurrentThread.Program[CurrentThread.PC].ToString());

                    // Error-safe ICommand.Do.
                    try
                    {
                        CurrentThread.Program[CurrentThread.PC].Do(CurrentThread);
                    }
                    catch (Exception ex)
                    {
                        throw new Exceptions.RuntimeException(string.Format("Runtime error at command #{0} ({1}).",
                            CurrentThread.PC, CurrentThread.Program[CurrentThread.PC].ToString()), ex, CurrentThread);
                    }

                    // If there was no jump, then increse the program counter
                    if (oldPC == CurrentThread.PC && CurrentThread.State == ThreadStates.Running)
                    {
                        ++CurrentThread.PC;
                    }
                    ++workingCycles;
                }
            }
            ++cycles;

            // Checking if we should request an interrupt.
            processorInterruptList.Where(i => (cycles - i.LastInterruptTime) >= i.Frequence).ToList().ForEach(
                irq => irq.Interrupt(cycles));
        }

        /// <summary>
        /// Returns the cycles made so far.
        /// </summary>
        public int Cycles
        {
            get
            {
                return cycles;
            }
        }

        /// <summary>
        /// Returns the cycles that were spent on non-idle operations.
        /// </summary>
        public int WorkingCycles
        {
            get
            {
                return workingCycles;
            }
        }
        
        #endregion

        #region Registers

        public IRegistry Registry { get; internal set; }

        #endregion

        private Thread currentThread;

        public Thread CurrentThread 
        {
            get { return currentThread; }
            set
            {
                if (currentThread != null)
                {
                    currentThread.Registry = this.Registry;
                }
                
                currentThread = value;
                
                if (currentThread != null)
                {
                    this.Registry = value.Registry;
                }
            }
        }


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
