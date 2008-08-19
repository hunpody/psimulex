using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A general class that is responsible for storing the estimated time that a complex operation will take.
    /// </summary>
    public static class Delayer
    {
        /// <summary>
        /// The current value of the delaying. 
        /// </summary>
        private static int delay = 0;

        /// <summary>
        /// The summary of delays called since BeginOperation().
        /// </summary>
        public static int TotalDelay
        {
            get
            {
                return delay;
            }
        }

        /// <summary>
        /// When beginning a processor instruction this method should be called.
        /// </summary>
        public static void BeginOperation()
        {
            delay = 0;
        }

        /// <summary>
        /// Makes the processor simulated busy.
        /// </summary>
        /// <param name="cycles"></param>
        public static void Delay(int cycles)
        {
            delay += cycles;
        }

        /// <summary>
        /// It is only formal, you don't have to call it.
        /// </summary>
        public static void EndOperation()
        {
        }
    }
}
