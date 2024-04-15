using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFTP
{
    internal interface ISimpleFTP
    {
        void SendAMsg(string msg);
        void ConnectServer();
    }

    class MyFTP : ISimpleFTP
    {
        public void SendAMsg(string msg)
        {
            Console.WriteLine($"Simple Msg: {msg}");
        }

        public void ConnectServer()
        {
            Console.WriteLine("Connected to simple server");
        }
    }
}
