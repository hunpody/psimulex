﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class FunctionPointer : BaseType
    {
        public override TypeIdentifier Type
        {
            get { return TypeEnum.FunctionPointerType; }
        }
    }
}
