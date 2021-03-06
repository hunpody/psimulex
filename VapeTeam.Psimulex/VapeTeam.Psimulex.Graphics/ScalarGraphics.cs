using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using System.Windows.Threading;
using String=VapeTeam.Psimulex.Core.Types.String;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Graphics
{
	public class ScalarGraphics : GraphicsElement
	{
		private enum Modes
		{
			Display,
			Edit
		}

		private Modes currentMode;

		private static readonly FontFamily symbolFont;
		private static readonly FontFamily normalFont;

		protected BaseType value;

		protected Label label;
		protected TextBox textBox;

		public Label Label
		{
			get { return label; }
		}

		public ScalarGraphics(BaseType value)
		{
			this.value = value;
			label = new Label();
            Content = label;
            label.Padding = new Thickness(4);
            label.Margin = new Thickness(0);
			value.Changed += value_Changed;

			this.MouseDoubleClick += ScalarGraphics_MouseDoubleClick;

			currentMode = Modes.Display;

			Update();
		}

		protected virtual void switchToEdit()
		{
			Content = textBox;
		}

		protected virtual void switchToDisplay()
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

		void ScalarGraphics_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (currentMode == Modes.Display)
			{
                e.Handled = true;
                if (textBox == null)
				{
					textBox = new TextBox();
					textBox.KeyDown += new System.Windows.Input.KeyEventHandler(tb_KeyDown);
					textBox.HorizontalAlignment = HorizontalAlignment.Stretch;
					textBox.VerticalAlignment = VerticalAlignment.Stretch;
					textBox.MinWidth = this.ActualWidth;
                    textBox.Padding = new Thickness(2.0);
				    textBox.FontSize = 12;
				}
				switchToEdit();
				currentMode = Modes.Edit;
				Update();

                // We cannot set focus here because the tree consisting of graphical elements represented by WPF
                // does not contain the textbox yet.
				// It gets rebuilded after all user code.
				Dispatcher.BeginInvoke(DispatcherPriority.Render,
					new DispatcherOperationCallback(ScalarGraphics.setTextBoxFocus), textBox);

			}
		}

		void tb_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				switchToDisplay();
				currentMode = Modes.Display;
				value.Assign(new String(textBox.Text));
				base.Update();
				e.Handled = true;
			}
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
				case Modes.Display:
					if (TypeHierarchy.IsNumeric(value) && value.ToInt() == Int32.MaxValue)
					{
						label.Content = "¥";
						label.FontFamily = symbolFont;
						label.FontSize = 16;
					}
					else if (TypeHierarchy.IsNumeric(value) && value.ToInt() == -Int32.MaxValue)
					{
						label.Content = "-¥";
						label.FontFamily = symbolFont;
						label.FontSize = 16;
					}
					else
					{
						label.FontFamily = normalFont;
						label.FontSize = 12;
						label.Content = value.ToString();
					}
					break;
				case Modes.Edit:
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

		public override void Dispose()
		{
			if (value != null)
				value.Changed -= value_Changed;
		}
	}
}
