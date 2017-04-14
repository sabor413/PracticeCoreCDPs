using System.Data;
using System.Data.Common;
using PracticeCoreCDPs.Core;

namespace PracticeCoreCDPs.Areas.AbsFactory.Core
{
    public class DatabaseHelper
    {
        //Adding a comment, testing GIT
        private readonly IDatabaseFactory _factory;

        public DatabaseHelper(IDatabaseFactory factory)
        {
            _factory = factory;
        }

        public DbDataReader ExecuteSelect(string query)
        {
            DbConnection cnn = _factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = _factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DbDataReader ExecuteSelect(string query, DbParameter[] parameters)
        {
            DbConnection cnn = _factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = _factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(parameters);
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int ExecuteAction(string query)
        {
            DbConnection cnn = _factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = _factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }

        public int ExecuteAction(string query, DbParameter[] parameters)
        {
            DbConnection cnn = _factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = _factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(parameters);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
    }
}
