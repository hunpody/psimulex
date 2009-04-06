using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Graphics
{
	public class IteratorGraphics : GraphicsElement
	{
		private Rectangle rect;
		private DrawingBrush iteratorArrow;

		private VapeTeam.Psimulex.Core.Types.Iterator iterator;
		private IEnumerableGraphics container;

		public int Position
		{
			get { return iterator.Position; }
		}

        public IteratorGraphics(IEnumerableGraphics container, VapeTeam.Psimulex.Core.Types.Iterator iterator)
			: base()
		{
			this.iterator = iterator;
			this.container = container;
			this.iteratorArrow = (DrawingBrush) FindResource("IteratorArrow");

			rect = new Rectangle();
			rect.Fill = iteratorArrow;
			rect.Width = 15;
			rect.Height = 20;

			this.Content = rect;

			iterator.Changed += iterator_Changed;
			//iterator.Cleaning += new EventHandler(iterator_Cleaning);

			container.AttachIterator(this);
		}

		void iterator_Cleaning(object sender, EventArgs e)
		{
			container.DetachIterator(this);
		}

		void iterator_Changed(object sender, VapeTeam.Psimulex.Core.Types.BaseType.ValueChangedEventArgs e)
		{
			container.DrawIterator(this);
		}
	}
}
