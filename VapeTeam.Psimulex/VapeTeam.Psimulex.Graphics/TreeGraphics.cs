using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Graphics.Factories;
using System.Windows.Shapes;

namespace VapeTeam.Psimulex.Graphics
{
	public class TreeGraphics : GraphicsElement, IDisposable
	{
		private Core.Types.TreeBase tree;
		public Core.Types.TreeBase Tree { get { return tree; } }

		private TreeNodeGraphics root;

		private Canvas canvas;

		private EventHandler valueInitHandler;

		public TreeGraphics(Core.Types.TreeBase t)
		{
			tree = t;
			canvas = new Canvas();
			canvas.SnapsToDevicePixels = false;
            this.SnapsToDevicePixels = false;
			SnapsToDevicePixels = false;
			Border b = new Border();
			b.BorderBrush = Brushes.Black;
			canvas.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
			canvas.VerticalAlignment = System.Windows.VerticalAlignment.Top;
			HorizontalContentAlignment = System.Windows.HorizontalAlignment.Stretch;
			VerticalContentAlignment = System.Windows.VerticalAlignment.Stretch;
			b.Child = canvas;
			Content = b;

			Update();

			tree.Changed += tree_Changed;
		}

		void  tree_Changed(object sender, EventArgs e)
		{
			Update();
		}

		public static void PreOrder(TreeNodeGraphics tg, Action<TreeNodeGraphics> action)
		{
			action(tg);
			foreach (TreeNodeGraphics child in tg.Children)
				PreOrder(child, action);
		}

		private void requestUpdate(TreeGraphics tg)
		{
			Dispatcher.BeginInvoke(DispatcherPriority.Render, new DispatcherOperationCallback(delegate(object state)
			{
				tg.Update();
				return null;
			}), null);
			
		}

		public void PlaceNodesOntoCanvas()
		{
			canvas.Children.Clear();

			if (root != null)
			{
				root.WidthChanged -= root_WidthChanged;
				root.Dispose();
			}

			root = CreateTree(this, tree);

			root.WidthChanged += root_WidthChanged;
			PreOrder(root, delegate(TreeNodeGraphics tg)
			{
				canvas.Children.Add(tg);
				if (tg.Child is TreeGraphics)
					(tg.Child as TreeGraphics).PlaceNodesOntoCanvas();
			});

		}

		public void DoLayout()
		{
			maxX = 0;
			maxY = 0;
			if (root.HasTreeInside)
				(root.Child as TreeGraphics).DoLayout();
			layoutNode(root, 0, 0);
			canvas.Width = maxX + 4;
			canvas.Height = maxY + 4;
			this.Width = canvas.Width;
			this.Height = canvas.Height;
		}
		private static int invocationCount = 0;
		public override void Update()
		{
			PlaceNodesOntoCanvas();

			// Layout should be calculated in the background (in a separate thread) since 
			// WPF must calculate the size of the nodes first.
			Dispatcher.BeginInvoke(DispatcherPriority.Render, new DispatcherOperationCallback(delegate(object state)
			{
				++invocationCount;
				this.DoLayout();
	//			if (ParentGraphics is TreeNodeGraphics) (ParentGraphics as TreeNodeGraphics).InvalidateWidth();
				return null;
			}), null);
		}

		void root_WidthChanged(object sender, EventArgs e)
		{
			Update();
		}

		public static TreeNodeGraphics CreateTree(GraphicsElement root, Core.Types.TreeBase tree)
		{
			TreeNodeGraphics tg = new TreeNodeGraphics(tree);
			tg.ParentGraphics = root;
			if (tree.GetChildrenAsTreeBase().Count() > 0)
			{
				foreach (TreeBase child in tree.GetChildrenAsTreeBase())
				{
					if (child != null)
						tg.Add(CreateTree(tg, child));
				}
			}
			return tg;
		}

		private void drawUpperLine(TreeNodeGraphics node)
		{
			if (node.ParentTreeGraphics != null)
			{
				Line upLine = new Line();
				upLine.Y1 = -2;
				upLine.Y2 = 2;
				upLine.Stroke = Brushes.Black;
				canvas.Children.Add(upLine);
				upLine.SnapsToDevicePixels = false;
				upLine.StrokeThickness = 1;
				Canvas.SetLeft(upLine, SnapToPixel(Canvas.GetLeft(node) + node.CalculatedWidth / 2 + 2, upLine.StrokeThickness));
				Canvas.SetTop(upLine, SnapToPixel(Canvas.GetTop(node), upLine.StrokeThickness));
			}
		}

        private double SnapToPixel(double x, double penWidth)
        {
            return x;// Math.Round(x); +penWidth / 2;
        }

		private double getHorizontalOffset(TreeNodeGraphics node)
		{
			TreeNodeGraphics firstChild = node.Children[0];
			TreeNodeGraphics lastChild = node.Children[node.NumberOfChildren - 1];

			double plus = 2;

			double firstX = Canvas.GetLeft(firstChild) + firstChild.CalculatedWidth / 2 + plus;
			double lastX = Canvas.GetLeft(lastChild) + lastChild.CalculatedWidth / 2 + plus;

			double centerX = (firstX + lastX) / 2;
			return centerX - node.CalculatedWidth / 2;
		}

		private void drawHorizontalLine(TreeNodeGraphics node)
		{
			if (node.NumberOfChildren > 1)
			{
				TreeNodeGraphics firstChild = node.Children[0];
				TreeNodeGraphics lastChild = node.Children[node.NumberOfChildren - 1];
				// connect the two points

				double firstX = Canvas.GetLeft(firstChild) + firstChild.CalculatedWidth / 2 + 2;
				double lastX = Canvas.GetLeft(lastChild) + lastChild.CalculatedWidth / 2 + 2;
				Line hori = new Line();
				hori.X2 = lastX - firstX;
				canvas.Children.Add(hori);
				hori.Stroke = Brushes.Black;
				hori.SnapsToDevicePixels = false;
				hori.StrokeThickness = 1;
				Canvas.SetLeft(hori, SnapToPixel(firstX, hori.StrokeThickness));
				Canvas.SetTop(hori, SnapToPixel(Canvas.GetTop(firstChild) - 2, hori.StrokeThickness));
			}
		}

		private void drawLowerLine(TreeNodeGraphics node)
		{
			if (node.NumberOfChildren > 0)
			{
				Line downLine = new Line();
				downLine.Y2 = 6;
				canvas.Children.Add(downLine);
				downLine.Stroke = Brushes.Black;
				downLine.StrokeThickness = 1;
				downLine.SnapsToDevicePixels = false;
				Canvas.SetTop(downLine, SnapToPixel(Canvas.GetTop(node) + node.CalculatedHeight + 2, downLine.StrokeThickness));
				Canvas.SetLeft(downLine, SnapToPixel(Canvas.GetLeft(node) + node.CalculatedWidth / 2 + 2, downLine.StrokeThickness));
			}
		}

		private double maxX, maxY;

		private void layoutNode(TreeNodeGraphics node, double top, double left)
		{
			// gyerekek elhelyezése (relatív pozíció)
			// a csúcs elhelyezése

//			node.Update();

			double pad = node.TotalWidth / 2 - node.CalculatedWidth / 2;

			if (node.ParentTreeGraphics != null && node.ParentTreeGraphics.NumberOfChildren == 1
				&& node.ParentTreeGraphics.CalculatedWidth > node.CalculatedWidth)
			{
				pad = node.ParentTreeGraphics.CalculatedWidth / 2 - node.CalculatedWidth / 2;
			}

			Canvas.SetLeft(node, pad + left);
			Canvas.SetTop(node, top);

			double oldleft = left;

			foreach (TreeNodeGraphics tg in node.Children)
			{
				layoutNode(tg, top + node.CalculatedHeight + 10, left);
				left += tg.TotalWidth + 10;
			}

			if (node.NumberOfChildren > 0)
			{
				double offset = getHorizontalOffset(node);
				Canvas.SetLeft(node, offset - 2);
				Canvas.SetTop(node, top);
			}

			drawUpperLine(node);
			drawHorizontalLine(node);
			drawLowerLine(node);

			double x,y;
			if ((x = Canvas.GetLeft(node) + node.CalculatedWidth) > maxX)
				maxX = x;
			if ((y = Canvas.GetTop(node) + node.CalculatedHeight) > maxY)
				maxY = y;
		}

		#region IDisposable Members

		public override void Dispose()
		{
			root.WidthChanged -= root_WidthChanged;
			root.Dispose();
			//tree.ValueInitialized -= valueInitHandler;
			if (tree.Value != null)
				tree.Value.Changed -= tree_Changed;
			tree.Changed -= tree_Changed;
		}

		#endregion
	}
}
