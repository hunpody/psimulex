using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        string msg = string.Format("{0}", e.ToString());
        _errorMessages.Add(msg);
    }

    public override void EmitErrorMessage(string msg)
    {
        _errorMessages.Add(msg);
    }
}
