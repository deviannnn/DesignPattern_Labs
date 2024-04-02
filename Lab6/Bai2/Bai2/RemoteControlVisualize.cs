using CommandBase;
using ConcreteCommand;
using Receiver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai2
{
    public partial class RemoteControlVisualize : Form
    {
        Command[] cmds;
        Label[] slots;
        public Stack<Command> undoStack;
        public Stack<Command> redoStack;

        public RemoteControlVisualize()
        {
            InitializeComponent();

            undoStack = new Stack<Command>();
            redoStack = new Stack<Command>();

            slots = new Label[7] { slot1, slot2, slot3, slot4, slot5, slot6, slot7 };
            cmds = new Command[7] { new NoThingCmd(slot1), new NoThingCmd(slot2), new NoThingCmd(slot3), new NoThingCmd(slot4), new NoThingCmd(slot5), new NoThingCmd(slot6), new NoThingCmd(slot7), };
        }

        private void lightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Control sourceControl = owner.SourceControl;
                    if (sourceControl == null) return;
                    sourceControl.Text = menuItem.Text;
                    var slot = int.Parse(sourceControl.Tag?.ToString() ?? "0");

                    if (menuItem.Text == "Light")
                    {
                        cmds[slot] = new LightCmd(new Light(), slots[slot]);
                    }
                    else if (menuItem.Text == "Hottub")
                    {
                        cmds[slot] = new HottubCmd(new Hottub(), slots[slot]);
                    }
                    else if (menuItem.Text == "TV")
                    {
                        cmds[slot] = new TVCmd(new TV(), slots[slot]);
                    }
                }
            }
        }

        private void btnOnSlot1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int slotIndex = int.Parse(btn.Text) - 1;
            if (!(cmds[slotIndex] is NoThingCmd))
            {
                cmds[slotIndex].On();
                undoStack.Push(cmds[slotIndex]);
                redoStack.Clear();
            }
        }

        private void btnOffSlot1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int slotIndex = int.Parse(btn.Text) - 1;
            if (!(cmds[slotIndex] is NoThingCmd)) 
            { 
                cmds[slotIndex].Off();
                undoStack.Push(cmds[slotIndex]);
                redoStack.Clear();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                Command lastCommand = undoStack.Pop();
                lastCommand.Undo();
                redoStack.Push(lastCommand);
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                Command lastUndoneCommand = redoStack.Pop();
                lastUndoneCommand.Undo();
                undoStack.Push(lastUndoneCommand);
            }
        }
    }
}
