using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Libraries
{
    public class StandardLibrary : ILibrary
    {
        public ISystemContext System { get; set; }

        public StandardLibrary(ISystemContext context)
        {
            System = context;
        }

        public void Print(string message)
        {
            // Access current process and add the message to its standard output
            // Then the characters will be displayed to the process's machines screen.
            Delayer.Delay(5);
            System.CallingProcess.AddToStandardOutput(message);
        }

        public string Concat(string a, string b)
        {
            Delayer.Delay(a.Length + b.Length);
            return a + b;
        }
    }
}
