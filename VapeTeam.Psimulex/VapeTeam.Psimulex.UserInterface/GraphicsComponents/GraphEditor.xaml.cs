using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace GraphDrawerPOC
{
    /// <summary>
    /// Interaction logic for GraphEditor.xaml
    /// </summary>
    public partial class GraphEditor : UserControl
    {
        private UIElement draggingElement;
        private Point mouseDownDifference;


        private UIElement AddElement(UIElement element, Point position)
        {
            var cc = new ContentControl { Content = element };

            //Canvas.SetLeft(cc, Canvas.GetLeft(element));
            //Canvas.SetTop(cc, Canvas.GetTop(element));

            Canvas.SetLeft(element, 0);
            Canvas.SetTop(element, 0);

            Canvas.SetLeft(cc, position.X);
            Canvas.SetTop(cc, position.Y);

            cc.Style = Resources["DesignerItemStyle"] as Style;
            canvas.Children.Add(cc);

            cc.MouseMove += new MouseEventHandler(cc_MouseMove);
            return cc;
        }

        void cc_MouseMove(object sender, MouseEventArgs e)
        {
            ContentControl elem = sender as ContentControl;
            ((Graph.Node)((Border)elem.Content).Tag).Position = new Point { X = Canvas.GetLeft(elem), Y = Canvas.GetTop(elem) };
            RedrawEdges();
        }

        Graph g;

        private Dictionary<Graph.Node, UIElement> nodesMap = new Dictionary<Graph.Node, UIElement>();
        private Dictionary<Graph.Edge, UIElement> edgesMap = new Dictionary<Graph.Edge, UIElement>();


        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
        }

        public GraphEditor()
        {
            InitializeComponent();
            this.SnapsToDevicePixels = true;
            canvas.IsHitTestVisible = true;
            IsHitTestVisible = true;

            canvas.Background = new SolidColorBrush(Colors.WhiteSmoke);

            canvas.MouseLeftButtonUp += new MouseButtonEventHandler(GraphEditor_MouseRightButtonUp);


            g = new Graph
            {
            };
            Random r = new Random();
            for (int i = 0; i < 12; ++i)
            {
                g.Nodes.Add(new Graph.Node
                {
                    Position = new Point(r.Next(0, 700), r.Next(0, 600)),
                    Size = new Size(42, 42)
                });
            }
            for (int i = 0; i < 20; ++i)
            {
                g.Edges.Add(new Graph.Edge { From = g.Nodes[r.Next(0, 12)], To = g.Nodes[r.Next(0,12)] });
            }


            int k = 0;
            foreach (var node in g.Nodes)
            {
                AddNode(node);
            }
            foreach (var edge in g.Edges)
            {
                AddEdge(edge);
            }

            RedrawEdges();

        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            RedrawEdges();
            base.OnMouseEnter(e);
        }


        private void AddEdge(Graph.Edge edge)
        {
            Line L = new Line { X1 = edge.From.Position.X, Y1 = edge.From.Position.Y, X2 = edge.To.Position.X, Y2 = edge.To.Position.Y };
            ConnectNodes(edge, L);
            L.Stroke = new SolidColorBrush(Colors.Black);
            L.StrokeThickness = 1f;
            canvas.Children.Add(L);
            L.MouseEnter += new MouseEventHandler(L_MouseEnter);
            L.MouseLeave += new MouseEventHandler(L_MouseLeave);

            edgesMap.Add(edge, L);
        }

        private Random rnd = new Random();

        private void AddNode(Graph.Node node)
        {
            VapeTeam.Psimulex.Core.Types.String s = new VapeTeam.Psimulex.Core.Types.String(rnd.Next(0, 100).ToString());
            var graphics = new Simulex.Graphics.Components.ScalarGraphics(s);
            graphics.IsHitTestVisible = true;

            Border b = new Border { Child = graphics, CornerRadius = new CornerRadius(10.0) };            
            b.BorderBrush = new SolidColorBrush(Colors.LightBlue);
            b.Background = new LinearGradientBrush(Color.FromArgb(0xFF, 0x8B, 0xC4, 0xE0), Color.FromArgb(0xFF, 0xEF, 0xFA, 0xFF), 90);
            b.BorderBrush = new SolidColorBrush(Colors.Black);
            b.BorderThickness = new Thickness(0.5f);
            b.IsHitTestVisible = false;
            b.Tag = node;
            b.Opacity = 1.0;

            b.MinWidth = node.Size.Width;
            b.MinHeight = node.Size.Height;

            b.MouseEnter += new MouseEventHandler(b_MouseEnter);
            b.MouseLeave += new MouseEventHandler(b_MouseLeave);

            var eff = new System.Windows.Media.Effects.DropShadowEffect { BlurRadius = 5, Color = Colors.Black, ShadowDepth = 1, Opacity = 0.5 };
            b.Effect = eff;



            var uielem = AddElement(b, node.Position);
            nodesMap.Add(node, uielem);
            //Canvas.SetLeft(b, node.Position.X);
            //Canvas.SetTop(b, node.Position.Y);
        }

        void GraphEditor_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            // The user wants to create a new node.
            if ((Keyboard.PrimaryDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                var clickedPosition = e.GetPosition(canvas);
                var node = new Graph.Node { Position = new Point(clickedPosition.X - 27, clickedPosition.Y - 27), Size = new Size(40,40) };
                g.Nodes.Add(node);
                AddNode(node);
            }
        }

        void b_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Border).Background = new LinearGradientBrush(Color.FromArgb(0xFF, 0x8B, 0xC4, 0xE0), Color.FromArgb(0xFF, 0xEF, 0xFA, 0xFF), 90);
        }

        void b_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Border).Background = new LinearGradientBrush(Colors.LightYellow, Colors.Wheat, 90);
        }

        private Point GetCenter(UIElement elem)
        {
            var bounds = new Rect { X = Canvas.GetLeft(elem), Y = Canvas.GetTop(elem), Width = elem.RenderSize.Width, Height = elem.RenderSize.Height };
            return new Point { X = bounds.Left + bounds.Width / 2, Y = bounds.Top + bounds.Height / 2 };
        }

        private void ConnectNodes(Graph.Edge edge, Line L)
        {
            var firstNodeVisual = nodesMap[edge.From];
            var secondNodeVisual = nodesMap[edge.To];
            var firstCenter = GetCenter(firstNodeVisual);
            var secondCenter = GetCenter(secondNodeVisual);
            L.X1 = firstCenter.X;
            L.Y1 = firstCenter.Y;
            L.X2 = secondCenter.X;
            L.Y2 = secondCenter.Y;
            //L. = new Thickness(10);
            Canvas.SetZIndex(L, -1);
        }

        void L_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Line).Stroke = new SolidColorBrush(Colors.Black);
        }

        void L_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Line).Stroke = new SolidColorBrush(Colors.Blue);
        }

        private void RedrawEdges()
        {
            foreach (var edge in g.Edges)
            {
                var line = edgesMap[edge] as Line;
                ConnectNodes(edge, line);
                line.Tag = line;
            }
        }


        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                canvas.Children.OfType<Border>().ToList().ForEach(b => b.IsHitTestVisible = false);
            }
        }
    }
}
