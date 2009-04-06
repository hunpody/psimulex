using System;
using System.Collections.Generic;
using System.Text;

namespace VapeTeam.Psimulex.Graphics
{
	public interface IEnumerableGraphics
	{
		void DrawIterator(IteratorGraphics iterator);
		void AttachIterator(IteratorGraphics iterator);
		void DetachIterator(IteratorGraphics iterator);
	}
}
