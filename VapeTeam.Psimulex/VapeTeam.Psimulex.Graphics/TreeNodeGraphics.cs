using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Graphics.Factories;

namespace VapeTeam.Psimulex.Graphics
{
	public class TreeNodeGraphics : BorderedGraphics, IDisposable
	{
		private Core.Types.TreeBase tree;
		public TreeBase Tree { get { return tree; } }
		private TreeNodeGraphics _parentTreeGraphics;
		public TreeNodeGraphics ParentTreeGraphics
		{
			get { return _parentTreeGraphics; }
			set { _parentTreeGraphics = value; }
		}

		private List<TreeNodeGraphics> _children;

		public List<TreeNodeGraphics> Children
		{
			get { return _children; }
		}

		public int NumberOfChildren { get { return _children.Count; } }

		public bool HasTreeInside
		{
			get { return Child is TreeGraphics; }
		}

		protected bool isWidthInvalidated;

		// bubbling up event for invalidating TotalWidth property
		public void InvalidateWidth()
		{
			isWidthInvalidated = true;
			if (_parentTreeGraphics != null)
				_parentTreeGraphics.InvalidateWidth();
			else
				OnWidthChanged();
		}

		private double totalWidth;
		public double TotalWidth
		{
			get 
			{
				if (isWidthInvalidated || totalWidth == 0)
				{
					isWidthInvalidated = false;
					double childrensTotalWidth = 0;
					double separator = 0;
					foreach (TreeNodeGraphics tg in Children)
					{
						childrensTotalWidth += tg.TotalWidth + separator;
						separator = 10;
					}
					return totalWidth = System.Math.Max(childrensTotalWidth, CalculatedWidth);
				}
				else return totalWidth;
			}
		}

		public double CalculatedWidth
		{
			get
			{
				return HasTreeInside ? (Child as TreeGraphics).Width : this.ActualWidth;
			}
		}
		public double CalculatedHeight
		{
			get
			{
				return HasTreeInside ? (Child as TreeGraphics).Height : this.ActualHeight;
			}
		}

		/*
		public double ChildrenWidth
		{
			get
			{
				double cw = 0;
				double sep = 0;
				foreach (TreeNodeGraphics tg in Children)
				{
					cw += tg.ActualWidth + sep;
					sep = 10;
				}
				return cw;
			}
		}
		*/

		public TreeNodeGraphics(Core.Types.TreeBase t)
			: base(GraphicsElementFactory.Produce(t.Value))
		{
			tree = t;
			tree.ValueInitialized += treeValueInitialized;
			_children = new List<TreeNodeGraphics>();
			isWidthInvalidated = true;
//			if (tree.Value != null)
//				tree.Value.Changed += tree_ValueChanged;
//			tree.Changed += tree_ValueChanged;
		}

		void tree_ValueChanged(object sender, EventArgs e)
		{
			InvalidateWidth();
		}

		public override void Update()
		{
			if (HasTreeInside)
				(Child as TreeGraphics).Update();
			InvalidateWidth();
//			ParentTreeGraphics.Update();
//			base.Update();
		}

		public void Add(TreeNodeGraphics tg)
		{
			_children.Add(tg);
			tg._parentTreeGraphics = this;
		}

		public event EventHandler WidthChanged;
		protected virtual void OnWidthChanged()
		{
			if (WidthChanged != null)
				WidthChanged(this, new EventArgs());
		}

		private void treeValueInitialized(object sender, EventArgs e)
		{
			this.Child.Dispose();
			this.Child = GraphicsElementFactory.Produce(tree.Value);
			this.Child.ParentGraphics = this.ParentGraphics;
//			tree.Value.Changed += new EventHandler(tree_ValueChanged);
			tree_ValueChanged(this, new EventArgs());
		}

		#region IDisposable Members

		public override void Dispose()
		{
			foreach (TreeNodeGraphics tg in Children)
				tg.Dispose();
			WidthChanged = null;
			tree.Changed -= tree_ValueChanged;
			if (tree.Value != null)
				tree.Value.Changed -= tree_ValueChanged;
			tree.ValueInitialized -= treeValueInitialized;
			Child.Dispose();
		}

		#endregion
	}
}
