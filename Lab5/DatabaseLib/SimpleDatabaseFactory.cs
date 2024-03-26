using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib
{
    public class SimpleDatabaseFactory
    {
        public DatabaseFactory CreateDbFactory(string dbType, string cnStr)
        {
            switch (dbType)
            {
                case "mssql":
                    return new SQLDatabaseFactory(cnStr);

                case "ole":
                    return new AccessDatabaseFactory(cnStr);

                default: return new SQLDatabaseFactory(cnStr);
            };
        }
    }
}
