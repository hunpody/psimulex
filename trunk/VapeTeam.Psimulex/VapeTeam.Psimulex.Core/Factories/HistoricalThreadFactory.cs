using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Historization;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class HistoricalThreadFactory : IThreadFactory
    {
        #region IThreadFactory Members

        private IHistory history;

        public HistoricalThreadFactory(IHistory history)
        {
            this.history = history;
        }

        public Thread CreateThread()
        {
            var t = new HistoricalThread();
            t.RunStack = new Historization.HistoricalStack<VapeTeam.Psimulex.Core.Types.BaseType>(history);
            t.CallStack = new HistoricalStack<State>(history);
            return t;
        }

        #endregion
    }
}
