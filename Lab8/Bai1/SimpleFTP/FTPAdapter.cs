using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFTP
{
    internal class FTPAdapter : ISimpleFTP
    {
        private IComplexFTP complexFTP;

        public FTPAdapter()
        {
            complexFTP = new ComplexFTP();
        }

        public void SendAMsg(string msg)
        {
            string[] msgs = new string[] { msg };
            complexFTP.SendMsgs(msgs);
        }

        public void ConnectServer()
        {
            complexFTP.Connect();
        } 
    }
}
