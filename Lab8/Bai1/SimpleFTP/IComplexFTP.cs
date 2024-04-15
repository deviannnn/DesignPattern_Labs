using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFTP
{
    internal interface IComplexFTP
    {
        void SendMsgs(string[] msgs);
        void Connect();
        string[] GetDirs();
    }

    class ComplexFTP : IComplexFTP
    {
        public void Connect()
        {
            Console.WriteLine("Connected to complex server");
        }

        public string[] GetDirs()
        {
            return new string[0];
        }

        public void SendMsgs(string[] msgs)
        {
            Console.WriteLine($"Complex Msg: {msgs[0]}");
        }
    }
}
