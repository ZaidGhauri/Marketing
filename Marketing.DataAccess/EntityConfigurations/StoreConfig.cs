using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class StoreConfig : EntityTypeConfiguration<Store>
    {
        public StoreConfig()
        {
            // Primary Key
            HasKey(s => s.Id);

            // Properties
            Property(s => s.Name).HasMaxLength(50).IsRequired();
            HasRequired(p => p.Website).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(true);

        
        }
    
    
    }
}
