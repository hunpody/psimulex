using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Result
{
    /// <summary>
    /// It contains a Dictionary about the commandObject, interval pairs.
    /// It determines a single step and an highlighting interval.
    /// </summary>
    public class CommandPositionChanges
    {
        public List<CommandInfo> CommandInfoList { get; set; }

        public CommandPositionChanges()
        {
            CommandInfoList = new List<CommandInfo>();
        }

        public bool Contains(CommandID commandID)
        {
            return GetInterval(commandID) == null ? false : true;
        }

        public Interval GetInterval(CommandID commandID)
        {
            return GetIndex(commandID) < 0 ? null : CommandInfoList[GetIndex(commandID)].Interval;
        }

        public int GetIndex(CommandID commandID)
        {
            return CommandInfoList.FindIndex
                (x =>
                    x.CommandID.CommandIndex == commandID.CommandIndex &&
                    x.CommandID.FunctionName == commandID.FunctionName &&
                    x.CommandID.FunctionParameterCount == commandID.FunctionParameterCount
                );
        }

        public void Add(CommandID commandID, Interval interval)
        {
            CommandInfoList.Add(new CommandInfo { CommandID = commandID, Interval = interval });
        }

        public Interval this[string functionName, int commandIndex]
        {
            get 
            {
                return this[new CommandID{ FunctionName = functionName, CommandIndex = commandIndex}]; 
            }
            set 
            {
                this[new CommandID { FunctionName = functionName, CommandIndex = commandIndex }] = value;
            }
        }

        public Interval this[CommandID commandID]
        {
            get 
            {
                return GetInterval(commandID);
            }
            set
            {
                if (!Contains(commandID))
                {
                    Add(commandID, value);
                }
                else
                {
                    CommandInfoList[GetIndex(commandID)].Interval = value;
                }
            }
        }
    }

    public class CommandInfo
    {
        public CommandID CommandID { get; set; }
        public Interval Interval { get; set; }
    }

    /// <summary>
    /// It identifies an interval in a file.
    /// </summary>
    [Serializable]
    public class Interval
    {
        public string FileName { get; set; }

        public int FromLine { get; set; }
        public int FromColumn { get; set; }
        public int ToLine { get; set; }
        public int ToColumn { get; set; }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public Interval()
        {
            FileName = "";
            FromLine = -1;
            FromColumn = -1;
            ToLine = -1;
            ToColumn = -1;
            StartIndex = -1;
            EndIndex = -1;
        }
    }

    /// <summary>
    /// It identifies an Command object.
    /// If the Function Name is "", than it is the main program. (Not the main() function!)
    /// </summary>
    public class CommandID
    {
        public string FunctionName { get; set; }
        public int FunctionParameterCount { get; set; }
        public int CommandIndex { get; set; }
    }
}
