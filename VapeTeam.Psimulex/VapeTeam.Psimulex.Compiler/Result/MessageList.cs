using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public class MessageList
    {
        public List<Information> Informations { get; set; }
        public List<Warning> Warnings { get; set; }
        public List<Error> Errors { get; set; }
        public List<AntlrError> AntlrErrors { get; set; }

        public MessageList()
        {
            Informations = new List<Information>();
            Warnings = new List<Warning>();
            Errors = new List<Error>();
            AntlrErrors = new List<AntlrError>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            AntlrErrors.ForEach(item => sb.AppendLine(item.ToString()));
            Informations.ForEach(item => sb.AppendLine(item.ToString()));
            Warnings.ForEach(item => sb.AppendLine(item.ToString()));
            Errors.ForEach(item => sb.AppendLine(item.ToString()));
            return sb.ToString();
        }
    }

    public enum MessageType
    {
        Information,
        Warning,
        Error,
        Antlr
    }

    public class Message
    {
        public string MessageText { get; set; }

        /// <summary>
        /// Source part.
        /// The subject of the message.
        /// </summary>
        public Interval Interval { get; set; }

        public virtual MessageType Type { get; private set; }

        public override string ToString()
        {
            return string.Format(
                //"{0} : In file \"{1}\" from [line,column] [{2},{3}] to [line,column] [{4},{5}] \n\t{6}",
                "{0} : In file \"{1}\" in line {2} {3}",
                Type.ToString(), Interval.FileName, Interval.FromLine, MessageText);
        }
    }

    public class Information : Message
    {
        public override MessageType Type { get { return MessageType.Information; } }
    }

    public class Warning : Message
    {
        public CompilerErrorCode ErrorCode { get; set; }
        public override MessageType Type { get { return MessageType.Warning; } }
    }

    public class Error : Message
    {
        public CompilerErrorCode ErrorCode { get; set; }
        public override MessageType Type { get { return MessageType.Error; } }
    }

    public class AntlrError : Message
    {
        public override MessageType Type { get { return MessageType.Antlr; } }
    }
}
