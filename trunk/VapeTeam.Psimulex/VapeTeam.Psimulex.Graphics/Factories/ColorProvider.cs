using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace VapeTeam.Psimulex.Graphics.Factories
{
	public class ColorProvider
	{
		static private List<Color> colors;

		static ColorProvider()
		{
			Color[] colorArray = new Color[8] 
			{ Colors.Green, Colors.Red, Colors.Blue, Colors.Brown, Colors.Cyan,
				Colors.Gold, Colors.Magenta, Colors.Yellow };
			colors = new List<Color>(colorArray);
		}

		static public Color ColorFromId(int id)
		{
			return colors[id % 8];
		}
	}
}
