using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("The Light was turned on");
        }

        public void Off()
        {
            Console.WriteLine("The Light was turned off");
        }
    }

    public class Hottub
    {
        public void PrepareJets()
        {
            Console.WriteLine("The Hottub is preparing");
        }

        public void JetsOn()
        {
            Console.WriteLine("The Hottub was on");
        }

        public void JetsOff()
        {
            Console.WriteLine("The Hottub was off");
        }
    }
}
