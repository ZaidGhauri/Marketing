using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class PromotionConfig : EntityTypeConfiguration<Promotion>
    {
        public PromotionConfig() 
       {   // Primary Key
            HasKey(p => p.Id);

            // Properties
            Property(p => p.Name).HasMaxLength(80).IsRequired();

         
       }


    }
}
