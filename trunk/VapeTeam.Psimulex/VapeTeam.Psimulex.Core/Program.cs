using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public class Program
    {
        public string Name { get; set; }

        private CommandList originalCommandList;
        public CommandList CommandList { get; private set; }

        protected List<UserDefinedFunction> Functions { get; private set; }
        protected TypeDescriptors UserDefinedTypes { get; private set; }

        //protected Dictionary<UserDefinedFunction, int> EntryPoints { get; private set; }

        public ICommandPositionProvider CommandPositionProvider { get; set; }

        public Program()
        {
            Name = "";
            CommandList = new CommandList();
            Functions = new List<UserDefinedFunction>();
            UserDefinedTypes = new TypeDescriptors();
            //EntryPoints = new Dictionary<UserDefinedFunction, int>();
        }

        /// <summary>
        /// Joins every user-defined function to the end of the command list.
        /// After calling this function you should NOT change the command list.
        /// </summary>
        public void JoinCommands()
        {
            originalCommandList = CommandList;
            CommandList = new CommandList();
            CommandList.AddRange(originalCommandList);
            if (CommandList.Count > 0 && !(CommandList.Last() is Return))
            {
                CommandList.Add(new Return(false));
            }
            //EntryPoints.Clear();
            foreach (var udf in Functions)
            {
                //EntryPoints.Add(udf, CommandList.Count);
                udf.EntryPoint = CommandList.Count;
                CommandList.AddRange(udf.Commands);
            }
        }

        public ICommand this[int index]
        {
            get
            {
                return CommandList[index];
            }
        }

        /// <summary>
        /// Adds a Command at the end of the CommandList
        /// </summary>
        /// <param name="command">The command</param>
        public void AddCommand(ICommand command)
        {
            CommandList.Add(command);
        }

        public void AddFunction(UserDefinedFunction function)
        {
            if (GetFunction(function.Name, function.ParameterCount) != null)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("There is already a user defined function with name \"{0}\" and having {1} parameters.",
                    function.Name, function.ParameterCount));
            }
            Functions.Add(function);
        }

        public void AddFunctions(List<UserDefinedFunction> functionList)
        {
            foreach (var func in functionList)
                AddFunction(func);
        }

        public UserDefinedFunction GetFunction(string name)
        {
            return Functions.FirstOrDefault(f => f.Name.ToLower() == name.ToLower());
        }

        public UserDefinedFunction GetFunction(string name, int parametersCount)
        {
            return Functions.FirstOrDefault(f => f.Name.ToLower() == name.ToLower() && f.ParameterCount == parametersCount);
        }

        public int GetCommandIndex(ICommand cmd)
        {
            return CommandList.GetCommandIndex(cmd);
        }

        /// <summary>
        /// The overall program size with the main (unnamed) method and all the functions.
        /// </summary>
        public int OverallProgramSize
        {
            get
            {
                return CommandList.Count + Functions.Sum(f => f.Commands.Count);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int lineNumber = 0;

            foreach (ICommand command in CommandList)
            {
                string line = "";
                line = lineNumber.ToString("000") + " " + command.ToString() + "\r\n";
                sb.Append(line);
                lineNumber++;
            }

            return sb.ToString();
        }

        public void AddUserDefinedType(ITypeDescriptor td)
        {
            UserDefinedTypes.AddDescriptor(td);
        }

        public ITypeDescriptor GetUserDefinedType(string name)
        {
            return UserDefinedTypes[name];
        }

        public UserDefinedType CreateAnInstanceOfUserDefinedType(string name)
        {
            return UserDefinedTypes.CreatAnInstanceOf(name);
        }
    }
}
