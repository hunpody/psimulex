using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Configuration
{
    public class CompilerSettings : System.Configuration.ConfigurationSection
    {
        [System.Configuration.ConfigurationProperty("compilerType")]
        public Type CompilerType { get; set; }
    }
}
