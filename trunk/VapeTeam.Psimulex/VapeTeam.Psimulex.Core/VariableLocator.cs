using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The VariableLocator is useful for pushing local variables into the runstack.
    /// </summary>
    public class VariableLocator : Dictionary<string, int>
    {
        public VariableLocator()
        {
        }

        /// <summary>
        /// Creates the new variablemap copying an existing one.
        /// </summary>
        /// <param name="locator"></param>
        public VariableLocator(VariableLocator locator)
        {
            foreach (var pair in locator)
            {
                this.Add(pair.Key, pair.Value);
            }
        }
    }
}
