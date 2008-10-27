using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Libraries
{
    public class StandardLibrary : ILibrary
    {
        public ISystemContext System
        {
            get
            {
                return OperatingSystem.CurrentContext;
            }
        }

        public Random Random { get; set; }

        public StandardLibrary()
        {
            Random = new Random();
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

        #region Tool Functions

        public int IntRandom(int min, int max)
        {
            return Random.Next(min, max);
        }

        public Decimal DecimalRandom()
        {
            return Convert.ToDecimal(Random.NextDouble());
        }

        public void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public int[] GenerateRandomIntArray(int length, int min, int max)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = Random.Next(min, max);

            return array;
        }

        public int GetOutputLength()
        {
            return System.CallingThread.HostProcess.StandardOutput.Length;
        }

        public void Write(string s)
        {
            Print(s + " ");
        }

        public void WriteLine(string s)
        {
            Print(s + "\r\n");
        }

        public string Input()
        {
            return "Input";
        }

        #endregion
    }
}
