using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Libraries
{
    public class StandardLibrary : ILibrary
    {
        private OperatingSystem System { get; set; }

        public void Print(string message)
        {
            // Access current process and add the message to its standard output
            // Then the characters will be displayed to the process's machines screen.
            Delayer.Delay(5);
            System.SystemCallingProcess.AddToStandardOutput(message + "\n");
        }
    }
}
