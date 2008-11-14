using System;
using System.Collections.Generic;
using System.Text;

namespace Simulex.Graphics.Components
{
	public interface ISelector
	{
		int Id { get; }
		int Index { get; }
	}

	public interface ISelectable
	{
		void Select(ISelector selector);
		void Deselect(ISelector selector);
	}
}
