using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Collections;
using System.Windows.Threading;

namespace Simulex.Graphics.Components
{
	public class BorderedGraphics : GraphicsElement, ISelectable
	{
		private Border border;
		public Border Border
		{
			get { return border; }
		}

		private Hashtable selectors;
//		private GraphicsElement child;

		//public GraphicsElement Child
		//{
		//    get { return child; }
		//}

		private GraphicsElement child;
		public GraphicsElement Child
		{
			get { return child; }
			protected set { border.Child = child = value; }
		}

		private void initGraphics()
		{
			if (border != null)
				border.Child = null;

			border = new Border();
			border.BorderBrush = Brushes.Gray;
			border.BorderThickness = new Thickness(0.5);
			border.Background = Brushes.Beige;

			border.Child = child;
			this.Margin = new Thickness(2.0);
			this.Content = border;
		}

		protected override void OnMouseEnter(System.Windows.Input.MouseEventArgs e)
		{
			border.Background = Brushes.LightBlue;
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e)
		{
			border.Background = Brushes.Beige;
			base.OnMouseLeave(e);
		}

		public BorderedGraphics(GraphicsElement ge)
		{
			selectors = new Hashtable();
			ge.ParentGraphics = this;
			child = ge;
			initGraphics();
		}

		public BorderedGraphics(ScalarGraphics sg)
			: this(sg as GraphicsElement)
		{
			sg.Label.VerticalAlignment = VerticalAlignment.Center;
			sg.Label.HorizontalAlignment = HorizontalAlignment.Center;
		}

		public void InitializeDraw()
		{
		}

		static private object FocusOnMe(object o)
		{
			(o as BorderedGraphics).Focus();
			return o;
		}

		#region ISelectable Members

		public void Select(ISelector selector)
		{
			if (!selectors.ContainsKey(selector))
			{
				Border b = new Border();
				b.BorderBrush = new SolidColorBrush(Graphics.Factories.ColorProvider.ColorFromId(selector.Id));
				b.BorderThickness = new Thickness(1.5);
				UIElement content = Content as UIElement;
				Content = null;
				b.Child = content;
				this.Content = b;
				this.Focus();
				selectors.Add(selector, b);
			}
		}

		public void Deselect(ISelector selector)
		{
			if (selectors.ContainsKey(selector))
			{
				Border b = selectors[selector] as Border;
				if (Content == b)
				{
					object c = b.Child;
					Content = null;
					b.Child = null;
					Content = c;
				}
				else if (b.Parent is Border)
				{
					UIElement uie = b.Child;
					b.Child = null;
					Border parent = b.Parent as Border;
					parent.Child = null;
					parent.Child = uie;
				}
				selectors.Remove(selector);
			}
		}

		#endregion
	}

}
