using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class EncryptedLogger : LoggerDecorator
    {
        public EncryptedLogger(Logger wrapObj) : base(wrapObj) { }
        public override void Log(string msg)
        {
            Console.WriteLine($"Encrypt msg: {msg}");
            WrapObj.Log(msg);
        }
    }
}
