using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib
{
    public abstract class DatabaseFactory
    {
        public string ConnectionStr { get; set; }

        public abstract DbConnection CreateConnection();
        public abstract DbConnection CreateConnection(string cnString);
        public abstract DbCommand CreateCommand();
        public abstract DbCommand CreateCommand(string cmdText);
        public abstract DbCommand CreateCommand(string cmdText, DbConnection connect);
        public abstract DbDataAdapter CreateDataAdapter();
        public abstract DbDataAdapter CreateDataAdapter(DbCommand selectCmd);
        public abstract DbDataReader CreateDataReader(DbCommand dbCmd);
        public abstract DbParameter CreateParameter(string name, object value);
    }
}
