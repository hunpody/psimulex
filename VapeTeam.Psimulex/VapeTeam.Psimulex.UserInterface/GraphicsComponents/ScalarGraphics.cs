using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using System.Windows.Threading;
using VapeTeam.Psimulex.Core.Types;

namespace Simulex.Graphics.Components
{
	public class ScalarGraphics : GraphicsElement
	{
		private enum Mode
		{
			Display,
			Edit
		}

		private Mode currentMode;

		private static FontFamily symbolFont;
		private static FontFamily normalFont;

		protected BaseType value;

		protected Label label;
		protected TextBox textBox;

		public Label Label
		{
			get { return label; }
		}

		public ScalarGraphics(BaseType value)
			: base()
		{
			this.value = value;
			label = new Label();
            label.VerticalContentAlignment = VerticalAlignment.Center;
            label.HorizontalContentAlignment = HorizontalAlignment.Center;
            label.IsHitTestVisible = true;
            Content = label;
			value.Changed += value_Changed;

            this.MouseUp += new MouseButtonEventHandler(ScalarGraphics_MouseUp);

			currentMode = Mode.Display;

			Update();
		}

        void ScalarGraphics_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (currentMode == Mode.Display)
            {
                e.Handled = true;
                if (textBox == null)
                {
                    textBox = new TextBox();
                    textBox.PreviewKeyDown += new KeyEventHandler(textBox_PreviewKeyDown);
                    textBox.KeyDown += new System.Windows.Input.KeyEventHandler(tb_KeyDown);
                    textBox.LostKeyboardFocus += new KeyboardFocusChangedEventHandler(textBox_LostKeyboardFocus);
                    textBox.HorizontalAlignment = HorizontalAlignment.Center;
                    textBox.VerticalAlignment = VerticalAlignment.Center;
                    textBox.TextAlignment = TextAlignment.Center;
                    //textBox.MinWidth = this.ActualWidth;
                }
                switchToEdit();
                currentMode = Mode.Edit;
                Update();

                // We cannot set the focus here because the visual tree is not built yet, it gets rebuilt after all user code have been executed.
                // This is why we need to dispatch here.
                Dispatcher.BeginInvoke(DispatcherPriority.Render,
                    new DispatcherOperationCallback(ScalarGraphics.setTextBoxFocus), textBox);

            }
        }

        void textBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            HandleSwitchToDisplay(e);
        }

        void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.PrimaryDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                textBox.AcceptsReturn = true;
            }
            else
            {
                textBox.AcceptsReturn = false;
            }
        }

		protected virtual void switchToEdit()
		{
			Content = textBox;
		}

		protected virtual void SwitchToDisplay()
		{
			Content = label;
		}

		static object setTextBoxFocus(object target)
		{
			TextBox tb = target as TextBox;
			tb.Focus();
			tb.SelectAll();
			return target;
		}

		void tb_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
            if (e.Key == Key.Enter)
            {
                // If the user has pressed CTRL+Enter then we put a new line into the textbox at the current cursor position
                if ((Keyboard.PrimaryDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    int oldSelectionStart = textBox.SelectionStart;
                    textBox.Text.Remove(oldSelectionStart, textBox.SelectionLength);
                    textBox.Text = textBox.Text.Insert(textBox.SelectionStart, System.IO.TextWriter.Null.NewLine);
                    textBox.Select(oldSelectionStart + 2, 0);
                    e.Handled = true;
                    return;
                }
                HandleSwitchToDisplay(e);
                value.Assign(new VapeTeam.Psimulex.Core.Types.String(textBox.Text));
            }
            else if (e.Key == Key.Escape)
            {
                HandleSwitchToDisplay(e);
            }
		}

        private void HandleSwitchToDisplay(RoutedEventArgs e)
        {
            SwitchToDisplay();
            currentMode = Mode.Display;
            base.Update();
            e.Handled = true;
        }

		static ScalarGraphics()
		{
			symbolFont = new FontFamily("Symbol");
			normalFont = new FontFamily("Tahoma");
		}

		void value_Changed(object sender, EventArgs e)
		{
			Update();
			base.Update();
		}

		public override void Update()
		{
			switch (currentMode)
			{
				case Mode.Display:
					if (TypeHierarchy.IsScalar(value) && value.ToInt() == Int32.MaxValue)
					{
						label.Content = "¥";
						label.FontFamily = symbolFont;
						label.FontSize = 14;
					}
					else if (TypeHierarchy.IsScalar(value) && value.ToInt() == -Int32.MaxValue)
					{
						label.Content = "-¥";
						label.FontFamily = symbolFont;
						label.FontSize = 14;
					}
					else
					{
						label.FontFamily = normalFont;
						label.FontSize = 11;
						label.Content = value.ToString();
					}
					break;
				case Mode.Edit:
					if (value.ToInt() == Int32.MaxValue)
						textBox.Text = "infinity";
					else if (value.ToInt() == -Int32.MaxValue)
						textBox.Text = "-infinity";
					else
						textBox.Text = value.ToString();
					break;
				default:
					break;
			}
		}

		public override void  Dispose()
		{
			if (value != null)
				value.Changed -= value_Changed;
		}
	}
}
