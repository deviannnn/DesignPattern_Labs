using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        CommandState state;

        public Command()
        {
            state = CommandState.NOTSET;
        }

        abstract protected void ExecuteOn();
        abstract protected void ExecuteOff();

        public void On()
        {
            state = CommandState.ON;
            ExecuteOn();
        }

        public void Off()
        {
            state = CommandState.OFF;
            ExecuteOff();
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
