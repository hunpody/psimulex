using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Collections;
using System.Windows;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Graphics
{
	public class RunstackDisplayer : GraphicsElement
	{
		private StackPanel panel;

		private RunStack runStack;

		public RunstackDisplayer(RunStack runStack)
		{
			panel = new StackPanel();
			this.runStack = runStack;
			this.Content = panel;
		}

        public override void Update()
        {
            foreach (UIElement ui in panel.Children)
                if (ui is GraphicsElement)
                    (ui as GraphicsElement).Dispose();

            panel.Children.Clear();
            int i = 0;

            foreach (var value in runStack.AsEnumerable())
            {
                if (panel.Children.Count > 0)
                    panel.Children.Add(new Separator() { SnapsToDevicePixels = false });

                var graph = new LabeledGraphics((runStack.Count - i).ToString(),
                    Graphics.Factories.GraphicsElementFactory.Produce(value));

                panel.Children.Add(graph);
                ++i;
            }
        }
	}
}
