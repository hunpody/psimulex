using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Wraps a system thread. (VapeTeam.Psimulex.Core.Thread)
    /// </summary>
    public class Thread : BaseType
    {
        private VapeTeam.Psimulex.Core.Thread thread;

        public Thread(VapeTeam.Psimulex.Core.Thread thread)
        {
            this.thread = thread;
        }

        public void Start()
        {
            thread.Start();
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Thread; }
        }
    }
}
