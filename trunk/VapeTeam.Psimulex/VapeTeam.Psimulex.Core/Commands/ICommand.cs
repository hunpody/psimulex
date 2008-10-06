using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// The basic interface for commands that are executable.
    /// </summary>
    public interface ICommand
    {
        Process HostProcess { get; }
        void Do(ICommandContext context);

        /* Ha marad rá idő. ( Microlex )
         * Teljes információs stringé alakítás. ( ANTLR nyelvtan álltal benyelt )
         * 
         * string SaveToString();
         * void LoadFromString(string command);
        */
    }

    public class CommandList : List<ICommand>
    {
        public int GetCommandIndex(ICommand cmd)
        {
            return FindIndex(command => command == cmd);
        }
    }
}
