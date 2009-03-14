using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;

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

        public SimpleCommandPositionProvider(CommandPositionChanges cmdChanges, Program program)
        {
            program.JoinCommands();

            //int currentCmdIndex = 0;
            //int previousCommandIndex = -1;
            foreach (var ci in cmdChanges.CommandInfoList)
            {
                if (cmdChanges.CommandInfoList.FirstOrDefault() == ci)
                    continue;

                var func = program.GetFunction(ci.CommandID.FunctionName);//, ci.CommandID.FunctionParameterCount);

                if (func == null)
                    continue;

                int currentCmdIndex = program.CommandList.IndexOf(func.Commands[ci.CommandID.CommandIndex]);

                positions.Add(new Pair
                {
                    CmdIndex = currentCmdIndex,
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


        /// <summary>
        /// Gets the last position that is before the supplied command.
        /// </summary>
        /// <param name="commandIndex"></param>
        /// <returns></returns>
        public VapeTeam.Psimulex.Core.SourcePosition GetPosition(int commandIndex)
        {
            var p = positions.LastOrDefault(pos => pos.CmdIndex <= commandIndex);
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
