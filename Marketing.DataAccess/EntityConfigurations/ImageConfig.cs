using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class ImageConfig : EntityTypeConfiguration<Image>
    {
        public ImageConfig() 
       {   // Primary Key
            HasKey(t => t.Id);
            Property(t => t.Name).HasMaxLength(400).IsRequired();
       }
   }
}
