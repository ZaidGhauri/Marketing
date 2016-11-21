using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig() 
       {   // Primary Key
            HasKey(p => p.Id);

            // Properties
            Property(p => p.Name).HasMaxLength(80).IsRequired();
            Property(p => p.Password).HasMaxLength(80).IsRequired();
            HasRequired(p => p.WebSite).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Country).WithMany().HasForeignKey(p => p.CountryId).WillCascadeOnDelete(false);
         
       }


    }
}
