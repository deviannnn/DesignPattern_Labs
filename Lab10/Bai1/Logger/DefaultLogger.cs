using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class DefaultLogger : Logger
    {
        public override void Log(string msg) 
        {
            Console.WriteLine($"Write msg: {msg}\n");
        }
    }
}
