using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Key Value Pair Record
    /// On the first place for the priority queue.
    /// </summary>
    class KeyValuePair
    {
        public BaseType Key { get; set; }
        public BaseType Value { get; set; }
    }
}
