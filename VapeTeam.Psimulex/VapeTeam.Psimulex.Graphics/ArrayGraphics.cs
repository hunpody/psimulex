using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Collections;
using VapeTeam.Psimulex.Graphics.Factories;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Graphics
{
	public class ArrayGraphics : ContainerGraphics, IDepthChangedListener
	{
		private class Selector : ISelector
		{
			private int id;
			private int index;
			private int depth;

			public int Depth
			{
				get { return depth; }
			}

			#region ISelector Members

			public int Id
			{
				get { return id; }
			}

			public int Index
			{
				get { return index; }
				set { index = value; }
			}

			public Selector(int id, int index, int depth)
			{
				this.id = id;
				this.index = index;
				this.depth = depth;
			}

			#endregion
		}

		protected int size;
		protected AbstractCollection container;

		private Dictionary<UIElement, Storyboard> sb;

		private BorderedGraphics[] graphics;
		private WrapPanel panel;

		private Hashtable indices;
		private Dictionary<int, Selector> selectors;

		public override void Update()
		{
//			for (int i = 0; i < graphics.Length; ++i)
//				graphics[i].Update();
			base.Update();
		}

		protected void ClearPanel()
		{
			panel.Children.Clear();
			indices = new Hashtable();
			selectors = new Dictionary<int, Selector>();
			sb = new Dictionary<UIElement, Storyboard>();
		}

        protected void CreateElements(AbstractCollection container)
		{
			graphics = new BorderedGraphics[size];

            IEnumerator<VapeTeam.Psimulex.Core.Types.BaseType> it = container.AsEnumerable().GetEnumerator();
			int i = 0;
			while (it.MoveNext())
			{
				BorderedGraphics elem = graphics[i] = new BorderedGraphics(
					GraphicsElementFactory.Produce(it.Current));

				elem.ParentGraphics = this;

				elem.HorizontalAlignment = HorizontalAlignment.Stretch;
				elem.VerticalAlignment = VerticalAlignment.Stretch;
				elem.InitializeDraw();
				panel.Children.Add(elem);
				++i;
			}
		}

		protected void Initialize(AbstractCollection container)
		{
			ClearPanel();
			this.container = container;
		    size = container.Count;

			CreateElements(container);

			Content = panel;
		}

		public Orientation Orientation
		{
			get { return panel.Orientation; }
			set { panel.Orientation = value; }
		}

        private static int CreateIdentifierFromIndexedEvent(int pc, int csDepth)
        {
            return csDepth*1000000 + pc;
        }

		void ArrayGraphics_Indexed(object sender, VapeTeam.Psimulex.Core.Types.AbstractCollection.IndexedEventArgs e)
		{
		    int eventIdentifier = CreateIdentifierFromIndexedEvent(e.IP, e.CallStackDepth);
			if (!selectors.ContainsKey(eventIdentifier))
				selectors.Add(eventIdentifier, new Selector(eventIdentifier, e.Index, e.CallStackDepth));
			else
			{
				graphics[selectors[eventIdentifier].Index].Deselect(selectors[eventIdentifier]);
			}
			selectors[eventIdentifier].Index = e.Index;
			graphics[e.Index].Select(selectors[eventIdentifier] as ISelector);
		}

		void rect_MouseLeave(object sender, MouseEventArgs e)
		{
			Rectangle r = e.Source as Rectangle;
			sb[r].Stop(this);
		}

		void rect_MouseEnter(object sender, MouseEventArgs e)
		{
			Rectangle r = e.Source as Rectangle;
			sb[r].Begin(this);
		}

		public ArrayGraphics(AbstractCollection container)
			: base()
		{
			panel = new WrapPanel();
			size = 0;
			this.Opacity = 1.0;
			Initialize(container);
			container.Changed += container_Changed;
            //container.IteratorCreated += new EventHandler<IteratorCreatedEventArgs>(container_IteratorCreated);

		    container.Indexed += ArrayGraphics_Indexed;

            //if (container is IIndexable)
            //{
            //    (container as ArrayWrapper).IndexChanged += new IndexChangedEventHandler(ArrayGraphics_IndexChanged);
            //}
		}

//        void container_IteratorCreated(object sender, IteratorCreatedEventArgs e)
//        {
////			IteratorGraphics itg = new IteratorGraphics(this, e.Iterator);
//        }

		void container_Changed(object sender, EventArgs e)
		{
			Initialize(container);
		}

		public override void DrawIterator(IteratorGraphics iterator)
		{
			if (iterator.Position >= 0)
			{
				iterator.Opacity = 1;
				Canvas.SetLeft(iterator, iterator.Position * 32);
			}
			else
			{
				iterator.Opacity = 0;
			}
		}

		public override void AttachIterator(IteratorGraphics iterator)
		{
//			canvas.Children.Add(iterator);
			Canvas.SetTop(iterator, -20);
		}

		public override void DetachIterator(IteratorGraphics iterator)
		{
//			canvas.Children.Remove(iterator);
		}


		#region IDepthChangedListener Members

		public void DepthChanged(object sender, DepthChangedEventArgs e)
		{
			List<Selector> removables = new List<Selector>();
			foreach (Selector sel in selectors.Values)
			{
				if (sel.Depth > e.Depth)
				{
					graphics[sel.Index].Deselect(sel);
					removables.Add(sel);
				}
			}

			foreach (Selector sel in removables)
				selectors.Remove(sel.Id);
		}

		#endregion
	}
}
