using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core
{
    public class Program
    {
        public string Name { get; set; }
        public CommandList CommandList { get; private set; }

        public Program()
        {
            Name = "";
            CommandList = new CommandList();
        }

        public ICommand this[int index]
        {
            get
            {
                return CommandList[index];
            }
        }

        /// <summary>
        /// Add a Command at the end of the Program
        /// </summary>
        /// <param name="command">The command</param>
        public void Add(ICommand command)
        {
            CommandList.Add(command);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int lineNumber = 0;

            foreach (ICommand command in CommandList)
            {
                string line = "";
                line = lineNumber.ToString("000") + " " + command.ToString() + "\r\n";
                sb.Append(line);
                lineNumber++;
            }

            return sb.ToString();
        }
    }
}
