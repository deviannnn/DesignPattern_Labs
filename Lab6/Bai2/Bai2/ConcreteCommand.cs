using CommandBase;
using Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcreteCommand
{
    public class NoThingCmd : Command
    {
        protected override string name { get => ""; }

        public NoThingCmd(Label slot) : base(slot) { }

        protected override void ExecuteOff() { }

        protected override void ExecuteOn() { }
    }

    public class LightCmd : Command
    {
        private Light light;
        protected override string name { get => "Light"; }

        public LightCmd(Light light, Label slot) : base(slot)
        {
            this.light = light;
        }

        protected override void ExecuteOn()
        {
            light.On();
        }

        protected override void ExecuteOff()
        {
            light.Off();
        }
    }

    public class HottubCmd : Command
    {
        private Hottub hottub;
        protected override string name { get => "Hottub"; }

        public HottubCmd(Hottub hottub, Label slot) : base(slot)
        {
            this.hottub = hottub;
        }

        protected override void ExecuteOn()
        {
            hottub.PrepareJets();
            hottub.JetsOn();
        }

        protected override void ExecuteOff()
        {
            hottub.JetsOff();
        }
    }
    public class TVCmd : Command
    {
        private TV tv;
        protected override string name { get => "TV"; }

        public TVCmd(TV tv, Label slot) : base(slot)
        {
            this.tv = tv;
        }

        protected override void ExecuteOn()
        {
            tv.On();
        }

        protected override void ExecuteOff()
        {
            tv.Off();
        }
    }
}
