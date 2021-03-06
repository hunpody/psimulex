﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VapeTeam.Psimulex.UserInterface.GraphicsComponents;

namespace VapeTeam.Psimulex.UserInterface
{
    /// <summary>
    /// Interaction logic for GraphDraw.xaml
    /// </summary>
    public partial class GraphDraw : Window
    {
        public GraphDraw()
        {
            InitializeComponent();
            this.Canvas.Children.Add(new GraphEditor());
        }
    }
}
