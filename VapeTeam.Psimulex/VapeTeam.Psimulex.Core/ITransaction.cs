using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A very light interface for transactions.
    /// </summary>
    public interface ITransaction
    {
        void Commit();
        void Rollback();
        TransactionStates Status { get; }
        void Invalidate();
    }
}
