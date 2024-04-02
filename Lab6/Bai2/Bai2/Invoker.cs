﻿using CommandBase;
using ConcreteCommand;
using System;
using System.Collections.Generic;

namespace Invoker
{
    public class RemoteControl
    {
        Command[] cmd;
        public Stack<Command> undoStack;
        public Stack<Command> redoStack;

        public RemoteControl()
        {
            
        }

        public void SetCommand(int slot, Command cmd)
        {
            this.cmd[slot] = cmd;
        }

        public void OnBtnWasPushed(int slot)
        {
            cmd[slot].On();
            undoStack.Push(cmd[slot]);
        }

        public void OffBtnWasPushed(int slot)
        {
            cmd[slot].Off();
            undoStack.Push(cmd[slot]);
        }

        public void UndoBtnWasPushed()
        {
            if (undoStack.Count > 0)
            {
                Command c = undoStack.Pop();
                redoStack.Push(c);
                c.Undo();
            } 
            else
            {
                Console.WriteLine("Can not Undo!\n");
            }
        }

        public void RedoBtnWasPushed()
        {
            if (redoStack.Count > 0)
            {
                Command c = redoStack.Pop();
                undoStack.Push(c);
                c.Undo();
            }
            else
            {
                Console.WriteLine("Can not Redo!\n");
            }
        }
    }
}
