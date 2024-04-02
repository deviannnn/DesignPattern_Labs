using CommandBase;
using Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteCommand
{
    public class NoThingCmd : Command
    {
        protected override void ExecuteOff()
        {
            Console.WriteLine("Do nothing\n");
        }

        protected override void ExecuteOn()
        {
            Console.WriteLine("Do nothing\n");
        }
    }

    public class LightCmd : Command
    {
        private Light light;

        public LightCmd(Light light)
        {
            this.light = light;
        }

        protected override void ExecuteOn()
        {
            light.On();
            Console.WriteLine();
        }

        protected override void ExecuteOff()
        {
            light.Off();
            Console.WriteLine();
        }
    }

    public class HottubCmd : Command
    {
        private Hottub hottub;

        public HottubCmd(Hottub hottub)
        {
            this.hottub = hottub;
        }

        protected override void ExecuteOn()
        {
            hottub.PrepareJets();
            hottub.JetsOn();
            Console.WriteLine();
        }

        protected override void ExecuteOff()
        {
            hottub.JetsOff();
            Console.WriteLine();
        }
    }
}
