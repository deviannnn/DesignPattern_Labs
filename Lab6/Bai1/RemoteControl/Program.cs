using Invoker;
using Receiver;
using CommandBase;
using ConcreteCommand;
using System.Windows.Input;

class Program
{
    static void Main(string[] args)
    {
        Light light = new();
        Hottub hottub = new();

        Command cmd1 = new LightCmd(light);
        Command cmd2 = new HottubCmd(hottub);

        RemoteControl remote = new();
        remote.SetCommand(0, cmd1);
        remote.SetCommand(1, cmd2);

        // Push
        remote.OnBtnWasPushed(0);
        remote.OnBtnWasPushed(1);
        remote.OffBtnWasPushed(1);

        // Undo & Redo
        remote.UndoBtnWasPushed();
        remote.RedoBtnWasPushed();
        remote.UndoBtnWasPushed();
        remote.UndoBtnWasPushed();
        remote.UndoBtnWasPushed();
        remote.UndoBtnWasPushed();
        remote.RedoBtnWasPushed();
        remote.RedoBtnWasPushed();
    }
}