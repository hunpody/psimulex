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
    }

    public class CommandList : List<ICommand>
    {
    }
}
