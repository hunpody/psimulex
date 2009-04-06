using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Shapes;

namespace VapeTeam.Psimulex.Graphics
{
	abstract public class ContainerGraphics : GraphicsElement, IEnumerableGraphics
	{
		public ContainerGraphics()
			: base()
		{ }

		#region IEnumerableGraphics Members

		public virtual void DrawIterator(IteratorGraphics iterator)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public virtual void AttachIterator(IteratorGraphics iterator)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public virtual void DetachIterator(IteratorGraphics iterator)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		#endregion
	}
}
