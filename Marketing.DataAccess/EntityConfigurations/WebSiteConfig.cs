using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class WebSiteConfig : EntityTypeConfiguration<WebSite>
    {
        public WebSiteConfig()
        {
            // Primary Key
            HasKey(w => w.WebId);

            // Properties
            Property(w => w.Name).HasMaxLength(30).IsRequired();

        }


    }
}
