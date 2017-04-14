using System.Data.Entity;
using PracticeCoreCDPs.Core;

namespace PracticeCoreCDPs.Areas.Singleton.Core
{
    public class AppDbSingleton : DbContext
    {
        public AppDbSingleton() : base(AppSettings.ConnectionString)
        { }
        public DbSet<WebsiteMetadata> Metadata { get; set; }
    }
}
