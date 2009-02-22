using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// Tells the exact position of each command.
    /// </summary>
    public interface ICommandPositionProvider
    {
        SourcePosition GetPosition(int commandIndex);
    }
}
