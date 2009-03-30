using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Historization
{
    public class HistoricalThread : Thread
    {
        private int _pc { get; set; }
        private HistoricalProperty<int> _historicalPc;

        public HistoricalThread()
        {
            _historicalPc = new HistoricalProperty<int>(GlobalHistory.Instance, this, "_pc");
        }

        public override int PC
        {
            get
            {
                return _historicalPc.Value;
            }
            set
            {
                _historicalPc.Value = value;
                base.PC = value;
            }
        }
    }
}
