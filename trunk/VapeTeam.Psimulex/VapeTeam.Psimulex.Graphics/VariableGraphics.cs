using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using VapeTeam.Psimulex.Core.Types;
using String=System.String;

namespace VapeTeam.Psimulex.Graphics
{
	public class VariableGraphics : LabeledGraphics
	{
		public GraphicsElement Variable
		{
			get { return base.GraphElem; }
		}

		static private string getTypeName(BaseType value)
		{
		    return value.Type.TypeName;
		}

        public VariableGraphics(string name, BaseType value)
            : base(String.Format("{0} {1} : ", getTypeName(value), name),
                Graphics.Factories.GraphicsElementFactory.Produce(value))
        {
        }
	}
}
