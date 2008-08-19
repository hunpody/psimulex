using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class Call : CommandBase
    {
        private string procedureName;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            // It has to look up the availabe function names
            // IFunctionLookup

        }

        public Call(string procedureName)
        {
            this.procedureName = procedureName;
        }

        #endregion
    }
}
