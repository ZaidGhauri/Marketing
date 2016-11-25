using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class UserClassConfig : EntityTypeConfiguration<UserClass>
    {
        public UserClassConfig()
        {   // Primary Key
            HasKey(p => p.id);

            // Properties
            Property(p => p.Name).HasMaxLength(80).IsRequired();
            HasRequired(p => p.WebSite).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Country).WithMany().HasForeignKey(p => p.CountryId).WillCascadeOnDelete(false);

        }


    }
}
