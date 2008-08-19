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

        private CommandList commandList = new CommandList();
        public CommandList CommandList
        {
            get { return commandList; }
        }

        public ICommand this[int index]
        {
            get
            {
                return commandList[index];
            }
        }
    }
}
