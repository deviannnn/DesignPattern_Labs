using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib
{
    public class AccessDatabaseFactory : DatabaseFactory
    {
        public AccessDatabaseFactory(string cnString)
        {
            ConnectionStr = cnString;
        }

        public override DbConnection CreateConnection()
        {
            return new OleDbConnection(ConnectionStr);
        }

        public override DbConnection CreateConnection(string cnString)
        {
            return new OleDbConnection(cnString);
        }

        public override DbCommand CreateCommand()
        {
            return new OleDbCommand();
        }

        public override DbCommand CreateCommand(string cmdText)
        {
            return new OleDbCommand(cmdText);
        }

        public override DbCommand CreateCommand(string cmdText, DbConnection connect)
        {
            return new OleDbCommand(cmdText, (OleDbConnection)connect);
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OleDbDataAdapter();
        }

        public override DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new OleDbDataAdapter((OleDbCommand)selectCmd);
        }

        public override DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }

        public override DbParameter CreateParameter(string name, object value)
        {
            return new OleDbParameter(name, value);
        }
    }
}
