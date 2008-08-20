using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// Don't know yet if we really need a seperate call stack.
    /// Providing a cute Function&Variable Lookup interface in the running context maybe avoids having this stack.
    /// </summary>
    public class CallStack : TransactionalStack<int>
    {
    }
}
