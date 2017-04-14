using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PracticeCoreCDPs.Areas.Singleton.Core
{
    [Table("WebsiteMetadata")]
    public class WebsiteMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(40)]
        public string DefaultTheme { get; set; }
        [Required]
        [StringLength(50)]
        public string AdminEmail { get; set; }
        [Required]
        public bool LogErrors { get; set; }


        private static WebsiteMetadata instance;

        private WebsiteMetadata()
        {

        }

        public static WebsiteMetadata GetInstance()
        {
            if(instance == null)
            {
                using (AppDbSingleton db = new AppDbSingleton())
                {
                    if(!db.Metadata.Any())
                    {
                        db.Metadata.Add(new WebsiteMetadata() { Title = "My Application", AdminEmail = "admin@localhost", DefaultTheme = "Summer", LogErrors = true });
                        db.SaveChanges();
                    }
                    instance = db.Metadata.SingleOrDefault();
                }
            }
            return instance;
        }
    }
}
