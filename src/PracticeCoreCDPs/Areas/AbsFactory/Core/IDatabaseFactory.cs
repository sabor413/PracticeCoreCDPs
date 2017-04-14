using System.Data.Common;

namespace PracticeCoreCDPs.Areas.AbsFactory.Core
{
    public interface IDatabaseFactory
    {
        DbConnection GetConnection();
        DbCommand GetCommand();
        DbParameter GetParameter();
    }
}
