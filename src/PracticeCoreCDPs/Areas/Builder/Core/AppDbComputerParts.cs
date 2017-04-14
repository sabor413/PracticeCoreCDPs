using System.Data.Entity;
using PracticeCoreCDPs.Core;

namespace PracticeCoreCDPs.Areas.Builder.Core
{
    public class AppDbComputerParts : DbContext
    {
        public AppDbComputerParts() : base(AppSettings.ConnectionString)
        { }
        public DbSet<ComputerPart> ComputerParts { get; set; }
    }
}
