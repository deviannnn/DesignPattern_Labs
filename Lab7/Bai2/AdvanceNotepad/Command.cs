using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceNotepad
{
    interface ICommand
    {
        void Enable();
        void Disable();
    }

    class Command : ICommand
    {
        public ToolStripItem[] Items { get; set; }

        public Command(params ToolStripItem[] items)
        {
            Items = items;
        }

        public void Disable()
        {
            foreach (var item in Items)
            {
                item.Enabled = false;
            }
        }

        public void Enable()
        {
            foreach (var item in Items)
            {
                item.Enabled = true;
            }
        }
    }
}
