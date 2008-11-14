using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Input;

namespace DiagramDesigner
{
    public class MoveThumb : Thumb
    {
        private RotateTransform rotateTransform;
        private ContentControl designerItem;

        //private bool isDragging = false;

        public MoveThumb()        
        {
            DragStarted += new DragStartedEventHandler(this.MoveThumb_DragStarted);
            DragDelta += new DragDeltaEventHandler(this.MoveThumb_DragDelta);
            MouseUp += new System.Windows.Input.MouseButtonEventHandler(MoveThumb_MouseUp);
            MouseEnter += (s, e) => ForwardEvent(e);
            MouseLeave += (s, e) => ForwardEvent(e);
        }

        void ForwardEvent(RoutedEventArgs e)
        {
            if (!IsDragging)
            {
                this.designerItem = DataContext as ContentControl;
                Border b = designerItem.Content as Border;

                b.RaiseEvent(e);//new MouseEventArgs(Mouse.PrimaryDevice, 0) { RoutedEvent = Mouse.MouseMoveEvent });
            }
            
        }

        void MoveThumb_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.designerItem = DataContext as ContentControl;
            Border b = designerItem.Content as Border;

            b.Child.RaiseEvent(new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Right)
            {
                RoutedEvent = Mouse.MouseUpEvent
            });
        }

        private void MoveThumb_DragStarted(object sender, DragStartedEventArgs e)
        {
            this.designerItem = DataContext as ContentControl;

            if (this.designerItem != null)
            {
                this.rotateTransform = this.designerItem.RenderTransform as RotateTransform;
                e.Handled = true;
            }
        }

        private void MoveThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (this.designerItem != null)
            {
                Point dragDelta = new Point(e.HorizontalChange, e.VerticalChange);

                if (this.rotateTransform != null)
                {
                    dragDelta = this.rotateTransform.Transform(dragDelta);
                }

                Canvas.SetLeft(this.designerItem, Canvas.GetLeft(this.designerItem) + dragDelta.X);
                Canvas.SetTop(this.designerItem, Canvas.GetTop(this.designerItem) + dragDelta.Y);
                e.Handled = true;
            }
        }
    }
}
