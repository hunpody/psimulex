using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    using InterruptEventHandler = EventHandler<InterruptRequestEventArgs>;

    public class ProcessorInterruptInformation
    {
        public int InterruptId { get; set; }
        public int Frequence { get; set; }
        public int LastInterruptTime { get; set; }
        public InterruptEventHandler EventHandler { get; set; }

        public void Interrupt(int cycles)
        {
            LastInterruptTime = cycles;
            EventHandler(this, new InterruptRequestEventArgs());
        }
    }
}
