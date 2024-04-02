using System;
using System.Windows.Forms;

namespace CommandBase
{
    public enum CommandState
    {
        NOTSET,
        ON,
        OFF
    }

    public abstract class Command
    {
        Label slot { get; set; }
        protected abstract string name { get; }
        public CommandState state;

        public Command(Label slot)
        {
            this.slot = slot;
            state = CommandState.NOTSET;
            Show();
        }

        protected virtual void Show()
        {
            slot.Text = name + "\n" + state;
        }

        abstract protected void ExecuteOn();
        abstract protected void ExecuteOff();

        public void On()
        {
            state = CommandState.ON;
            ExecuteOn();
            Show();
        }

        public void Off()
        {
            state = CommandState.OFF;
            ExecuteOff();
            Show();
        }

        public void Undo()
        {
            switch (state)
            {
                case CommandState.ON:
                    Off();
                    break;
                case CommandState.OFF:
                    On();
                    break;
                case CommandState.NOTSET:
                    break;
                default:
                    throw new InvalidOperationException("Invalid command state.");
            }
        }
    }
}
