using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using global::Antlr.Runtime;

public partial class PsimulexParser 
{
    private List<string> _errorMessages = new List<string>();

    public List<string> ErrorMessages
    {
        get
        {
            return _errorMessages;
        }
    }

    public override void ReportError(Antlr.Runtime.RecognitionException e)
    {
        //string msg = string.Format("{0}", e.ToString());


        /*
          string msg = string.Format(
@"
Char                : {0}
CharPositionInLine  : {1}
Data                : {2}
Index               : {3}
InnerException      : {4}
UnexpectedType      : {5}
UnexpectedTypeName  : {6}
Message             : {7}
Node                : {8}
Source              : {9}
StackTrace          : {10}
Token               : {11}
Line                : {12}
Input               : {13}
",
 e.Char,
 e.CharPositionInLine,
 e.Data,    //System.Collections.ListDictionaryInternal
 e.Index,
 e.InnerException,
 e.UnexpectedType,
 e.UnexpectedType != -1 ? PsimulexParser.tokenNames[e.UnexpectedType] : "-1",
 e.Message,
 e.Node,
 e.Source,
 e.StackTrace,
 e.Token, 
 e.Line,
 e.Input    //Source
);
         */

        string msg = string.Format(" {0} [{1}:{2}]",
                e.UnexpectedType != -1 ? PsimulexParser.tokenNames[e.UnexpectedType] : "unknown",
                e.Line, e.CharPositionInLine);

        if (e.GetType() == typeof(MismatchedTokenException))
        {
            msg = string.Format("Mismatched token: {0}", msg);
        }
        else if (e.GetType() == typeof(MissingTokenException))
        {
            msg = string.Format("Missing token: {0}", msg);
        }
        else if (e.GetType() == typeof(NoViableAltException))
        {
            msg = string.Format("Unexpected symbol: {0}", msg);     
        }
        else
        {
            msg = string.Format("Problem: {0}", msg);    
        }

        _errorMessages.Add(msg);
    }

    public override void EmitErrorMessage(string msg)
    {
        _errorMessages.Add(msg);
    }
}
