using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Graphics
{
	public class MicrolexDisplayer : GraphicsElement
	{
		private class CommandSelector : ISelector
		{
			private int _id;
			private int _index;

			#region ISelector Members

			public int Id
			{
				get { return _id; }
			}

			public int Index
			{
				get { return _index; }
			}

			#endregion

			public CommandSelector(int id)
			{
				_id = id;
			}

			public CommandSelector()
				: this(0)
			{
			}
		}

		private StackPanel panel;

		private List<ICommand> program;
		private ICommandContext env;

		private List<ISelectable> commands;
		private CommandSelector selector;
		private int previousIP;

		private bool isRunning;
		public bool IsRunning
		{
			get { return isRunning; }
			set { isRunning = value; }
		}

        public MicrolexDisplayer(List<ICommand> _program, ICommandContext env)
			: this()
		{
			program = _program;
			this.env = env;
			selector = new CommandSelector();
			//env.InstructionPointerChanged += new EventHandler(env_InstructionPointerChanged);
			Initialize();
		}

		void env_InstructionPointerChanged(object sender, EventArgs e)
		{
			if (IsRunning)
				return;

			if (previousIP < commands.Count)
				commands[previousIP].Deselect(selector);
			commands[env.PC].Select(selector);
			previousIP = env.PC;
		}

		public MicrolexDisplayer()
		{
			panel = new StackPanel();
			this.Content = panel;
			isRunning = false;
		}

		public void Initialize(List<ICommand> _program)
		{
			program = _program;
			Initialize();
		}

		public void Initialize()
		{
			panel.Children.Clear();
			commands = new List<ISelectable>(program.Count);

			for (int i=0; i<program.Count; ++i)
			{
				BorderedGraphics bg = new BorderedGraphics(
					new LabeledGraphics(i.ToString(), new ScalarGraphics(new VapeTeam.Psimulex.Core.Types.String(program[i].ToString()))));
				(bg.Child as LabeledGraphics).LabelWidth = 75;
				bg.Margin = new System.Windows.Thickness(1.0);
				panel.Children.Add(bg);
				commands.Add(bg);
			}
		}
	}
}
