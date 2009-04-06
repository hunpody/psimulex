using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// General interface for indexing.
    /// </summary>
    public interface IIndexable
    {
        BaseType Index(int index, ICommandContext context);
    }
}
