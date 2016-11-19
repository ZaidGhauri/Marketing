using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class StoreConfig : EntityTypeConfiguration<Store>
    {
        public StoreConfig()
        {
            // Primary Key
            HasKey(s => s.StoreId);

            // Properties
            Property(s => s.StoreName).HasMaxLength(50).IsRequired();

        
        }
    
    
    }
}
