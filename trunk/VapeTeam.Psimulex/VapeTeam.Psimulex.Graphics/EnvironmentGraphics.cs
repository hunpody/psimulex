using System;
using System.Text;
using System.Windows.Controls;
using System.Collections;
using VapeTeam.Psimulex.Graphics.Windows;

namespace VapeTeam.Psimulex.Graphics
{
	public class DepthChangedEventArgs : EventArgs
	{
		private int _depth;
		public int Depth
		{
			get { return _depth; }
		}

		public DepthChangedEventArgs(int depth)
		{
			_depth = depth;
		}
	}
	public interface IDepthChangedListener
	{
		void DepthChanged(object sender, DepthChangedEventArgs e);
	}

	/// <summary>
	/// Displays the current running environment.
	/// It mainly displays the local variables.
	/// </summary>
	public class EnvironmentGraphics : GraphicsElement
	{
		private StackPanel panel;

		private Hashtable stateSeparators = new Hashtable();

		private System.Collections.Generic.Stack<StateGraphics> states;
		private StateGraphics TopState
		{
			get { return states.Peek(); }
		}

//		private List<IDepthChangedListener> depthListeners;

		private VapeTeam.Psimulex.Core.ICommandContext env;

		//private Dictionary<ContainerWrapper, ContainerGraphics> _containerMap;
		//public Dictionary<ContainerWrapper, ContainerGraphics> ContainerMap
		//{
		//    get { return _containerMap; }
		//}

		private void PushState()
		{
			StateGraphics sg = new StateGraphics();

			//if (states.Count > 0)
			//{
			//    Separator sep = new Separator();
			//    sep.Margin = new System.Windows.Thickness(4);
			//    panel.Children.Insert(0, sep);
			//    stateSeparators.Add(sg, sep);
			//}

			states.Push(sg);

			panel.Children.Insert(0, sg);

			setStatesSeparator();
		}

		private Separator createSeparator(StateGraphics sg)
		{
			Separator sep = new Separator();
			sep.Margin = new System.Windows.Thickness(4);
			panel.Children.Insert(0, sep);
			stateSeparators.Add(sg, sep);
			return sep;
		}

		private void PopState()
		{
			TopState.RemoveAll();
			StateGraphics sg = states.Pop();
			panel.Children.Remove(sg);
			if (stateSeparators.ContainsKey(sg))
				panel.Children.Remove((Separator) stateSeparators[sg]);

			setStatesSeparator();
		}

		public EnvironmentGraphics(VapeTeam.Psimulex.Core.ICommandContext environment)
		{
			panel = new StackPanel();
			panel.SnapsToDevicePixels = true;
			states = new System.Collections.Generic.Stack<StateGraphics>();
//			depthListeners = new List<IDepthChangedListener>();
			env = environment;
            
			Content = panel;

            //environment.VariableCreated += new VariableEventHandler(environment_VariableCreated);
            //environment.VariableDeleted += new VariableEventHandler(environment_VariableDeleted);

		    environment.CallStack.Pushed += environment_StatePushed;
		    environment.CallStack.Popped += environment_StatePopped;

		    environment.VariableCreated += environment_VariableCreated;

            //environment.StatePushed += new EventHandler(environment_StatePushed);
            //environment.StatePopped += new EventHandler(environment_StatePopped);

			PushState();
		}

		void environment_StatePopped(object sender, EventArgs e)
		{
			PopState();
			onDepthChanged();
		}

		void environment_StatePushed(object sender, EventArgs e)
		{
			PushState();
		}

		void setStatesSeparator()
		{
			if (TopState.Count > 0)
			{
				if (!stateSeparators.ContainsKey(TopState))
					createSeparator(TopState);
			}
			else
			{
				if (stateSeparators.ContainsKey(TopState))
				{
					panel.Children.Remove(stateSeparators[TopState] as Separator);
					stateSeparators.Remove(TopState);
				}
			}
		}

        //void environment_VariableDeleted(object sender, VapeTeam.Psimulex.Core.Common.VariableEventArgs e)
        //{
        //    TopState.Remove(e.Name);
        //    if (e.Variable is ICleanable)
        //        (e.Variable as ICleanable).CleanUp();
        //    setStatesSeparator();
        //}

		void environment_VariableCreated(object sender, VapeTeam.Psimulex.Core.Common.VariableEventArgs e)
		{
			if (e.Variable.Type.TypeEnum == VapeTeam.Psimulex.Core.Types.TypeEnum.Iterator)
				return;

			VariableGraphics vg = new VariableGraphics(e.Name, e.Variable);
			if (vg.Variable is IDepthChangedListener)
				depthChanged += (vg.Variable as IDepthChangedListener).DepthChanged;


            vg.MouseUp += (_s, _e) =>
            {
                if (!_e.Handled && (System.Windows.Input.Keyboard.Modifiers & System.Windows.Input.ModifierKeys.Control) == System.Windows.Input.ModifierKeys.Control)
                {
                    var watcher = new WatchWindow();
                    watcher.LoadVariable(e.Variable, e.Name);
                    watcher.Show();
                    _e.Handled = true;
                }
            };

			TopState.Add(e.Name, vg);

			setStatesSeparator();
		}

		private event EventHandler<DepthChangedEventArgs> depthChanged;

		private void onDepthChanged()
		{
			if (depthChanged != null)
				depthChanged(this, new DepthChangedEventArgs(env.CallStack.Count));
		}
	}
}
