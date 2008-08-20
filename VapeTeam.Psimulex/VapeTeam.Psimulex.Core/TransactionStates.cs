using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The possible states of the transactions.
    /// </summary>
    public enum TransactionStates
    {
        Uncommitted,
        Committed,
        Rolledback,
        Invalid
    }
}
