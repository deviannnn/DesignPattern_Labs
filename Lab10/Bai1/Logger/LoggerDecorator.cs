using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class LoggerDecorator : Logger
    {
        protected Logger WrapObj;

        public LoggerDecorator (Logger wrapObj)
        {
            WrapObj = wrapObj;
        }
    }
}
