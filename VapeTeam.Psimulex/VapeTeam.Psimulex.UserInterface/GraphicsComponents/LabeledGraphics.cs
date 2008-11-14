using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
//using Simulex.Interpreter;

namespace Simulex.Graphics.Components
{
	public class LabeledGraphics : GraphicsElement
	{
		private GraphicsElement graphics;

		public GraphicsElement GraphElem
		{
			get { return graphics; }
		}

		private Grid grid;
		private Label label;

		private ColumnDefinition labelColumn;

		public double LabelWidth 
		{
			get { return labelColumn.Width.Value; }
			set { labelColumn.Width = new System.Windows.GridLength(value); }
		}

		public LabeledGraphics(string labelText, GraphicsElement graphics)
			: base()
		{
			grid = new Grid();
			label = new Label();
			label.Content = labelText;
			this.graphics = graphics;
			grid.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
			grid.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
			grid.RowDefinitions.Add(new RowDefinition());
			labelColumn = new ColumnDefinition();
			//labelColumn.Width = new System.Windows.GridLength(120);            
			grid.ColumnDefinitions.Add(labelColumn);
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			grid.Children.Add(label);
			grid.Children.Add(graphics);
			Grid.SetColumn(label, 0);
			Grid.SetColumn(graphics, 1);
			Grid.SetRow(label, 0);
			Grid.SetRow(graphics, 0);
			Content = grid;
		}

		public override void Dispose()
		{
			GraphElem.Dispose();
		}
	}

}
