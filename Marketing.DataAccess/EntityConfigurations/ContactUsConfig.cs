using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class ContactUsConfig : EntityTypeConfiguration<ContactUs>
    {
        public ContactUsConfig() 
       {   // Primary Key
            HasKey(p => p.Id);
            // Properties
            HasRequired(p => p.WebSite).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(false);
            HasOptional(p => p.Country).WithMany().HasForeignKey(p => p.CountryId).WillCascadeOnDelete(false);
       }
    }
}
