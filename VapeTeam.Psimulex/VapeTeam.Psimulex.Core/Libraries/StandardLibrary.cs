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

        /// <summary>
        /// Writes the message to the process's standard output.
        /// </summary>
        /// <param name="message"></param>
        public void Print(string message)
        {
            // Access current process and add the message to its standard output
            // Then the characters will be displayed to the process's machines screen.
            Delayer.Delay(5 + message.Length);
            System.CallingThread.HostProcess.AddToStandardOutput(message);
        }

        /// <summary>
        /// Concatenates two string.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Concat(string a, string b)
        {
            Delayer.Delay(a.Length + b.Length);
            return a + b;
        }

        /// <summary>
        /// Calls the systems new thread method.
        /// </summary>
        /// <param name="entryPoint">The instruction pointer of the program where the thread enters</param>
        /// <returns></returns>
        public Thread create_thread(int entryPoint)
        {
            return System.CreateThread(System.CallingThread, entryPoint);
        }
    }
}
