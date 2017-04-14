using System.Data.Common;
using System.Data.OleDb;

namespace PracticeCoreCDPs.Areas.AbsFactory.Core
{
    public class OleDbFactory : IDatabaseFactory
    {
        public DbConnection GetConnection()
        {
            return new OleDbConnection();
        }

        public DbCommand GetCommand()
        {
            return new OleDbCommand();
        }

        public DbParameter GetParameter()
        {
            return new OleDbParameter();
        }
    }
}
