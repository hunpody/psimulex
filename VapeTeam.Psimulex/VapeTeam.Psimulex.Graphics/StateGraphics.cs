using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace VapeTeam.Psimulex.Graphics
{
	public class StateGraphics : GraphicsElement
	{
		private Panel panel;
//		private StackPanel panel;
		private Dictionary<string, System.Windows.UIElement> variableMap;

		public int Count
		{
			get { return variableMap.Count; }
		}

		public StateGraphics()
			: base()
		{
			variableMap = new Dictionary<string, System.Windows.UIElement>();
			panel = new WrapPanel();
			panel.SnapsToDevicePixels = true;
			Content = panel;
		}
		public void Add(string name, GraphicsElement g)
		{
			if (!variableMap.ContainsKey(name))
			{
                var borderedGraphics = new Border { Padding = new System.Windows.Thickness(1.0), SnapsToDevicePixels = false, Child = g, BorderThickness = new System.Windows.Thickness(0.5), BorderBrush = System.Windows.Media.Brushes.Gray }; 
				variableMap.Add(name, borderedGraphics);
                panel.Children.Add(borderedGraphics);
                //System.Windows.Media.RotateTransform rotation =new System.Windows.Media.RotateTransform(90.0);
                //panel.Children.Add(new Separator() { RenderTransform = rotation, Height = panel.Height });
			}
		}
		public void Remove(string name)
		{
			if (variableMap.ContainsKey(name))
			{
				panel.Children.Remove(variableMap[name]);
				variableMap.Remove(name);
			}
		}
		public void RemoveAll()
		{
			foreach (System.Windows.UIElement g in variableMap.Values)
			{
				panel.Children.Remove(g);
			}
			variableMap.Clear();
		}
	}
}
