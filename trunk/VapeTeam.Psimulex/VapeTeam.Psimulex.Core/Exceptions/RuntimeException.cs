using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    public class RuntimeException : PsimulexCoreException
    {
        public int CommandId { get; private set; }
        public string CommandName { get; private set; }

        //public List<string> PsimulexStackTrace { get; private set; }
        public string PsimulexStackTrace { get; private set; }
        public RuntimeException(string message, Exception innerException, Thread thread)
            : base(message, innerException)
        {
            CommandId = thread.PC;
            CommandName = thread.Program[thread.PC].ToString();
            //PsimulexStackTrace = new List<string>();

            var stackTraceList = new List<string>(thread.CallStack.Count);

            stackTraceList.Add(string.Format("@{0} ({1})", CommandId, CommandName));

            foreach (var state in thread.CallStack.AsEnumerable())
            {
                stackTraceList.Add(string.Format("@{0} ({1})", state.PC, thread.Program[state.PC].ToString()));
            }

            PsimulexStackTrace = string.Join(",", stackTraceList.ToArray());
        }

        public override string ToString()
        {
            return InnerException.ToString();
            //return string.Format("Runtime exception: {0}.\r\nPsimulex Stack Trace: {1}. \r\n.NET details of exception: {2}.\r\n", base.Message, PsimulexStackTrace, base.ToString());            
        }
    }
}
