using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public class SimpleCommandPositionProvider : VapeTeam.Psimulex.Core.ICommandPositionProvider
    {
        private class Pair
        {
            public int CmdIndex { get; set; }
            public VapeTeam.Psimulex.Core.SourcePosition Position { get; set; }
        }

        private List<Pair> positions = new List<Pair>();

        public SimpleCommandPositionProvider(CommandPositionChanges cmdChanges)
        {
            foreach (var ci in cmdChanges.CommandInfoList)
            {
                positions.Add(new Pair
                {
                    CmdIndex = ci.CommandID.CommandIndex,
                    Position = new VapeTeam.Psimulex.Core.SourcePosition
                    {
                        FileName = ci.Interval.FileName,
                        FunctionName = ci.CommandID.FunctionName,
                        Line = ci.Interval.FromLine,
                        Column = ci.Interval.FromColumn
                    }
                });                
            }
            positions.Sort(new Comparison<Pair>((a, b) => a.CmdIndex - b.CmdIndex));
        }

        #region ICommandPositionProvider Members

        public VapeTeam.Psimulex.Core.SourcePosition GetPosition(int commandIndex)
        {
            var p = positions.LastOrDefault(pos => pos.CmdIndex < commandIndex);
            if (p != default(Pair))
            {
                return p.Position;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
