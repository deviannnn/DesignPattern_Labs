using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CompressLogger : LoggerDecorator
    {
        public CompressLogger(Logger wrapObj) : base(wrapObj) { }
        public override void Log(string msg)
        {
            Console.WriteLine($"Compress msg: {msg}");
            WrapObj.Log(msg);
        }
    }
}
