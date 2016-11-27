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
            Property(s => s.Name).HasMaxLength(150).IsRequired();
            HasRequired(p => p.WebSite).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(false);
            HasRequired(p => p.Picture).WithMany().HasForeignKey(p => p.PictureId).WillCascadeOnDelete(false);

        
        }
    
    
    }
}
