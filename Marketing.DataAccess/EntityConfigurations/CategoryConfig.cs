using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            // Primary Key
            HasKey(cat => cat.Id);
            // Properties
            Property(cat => cat.Name).HasMaxLength(50).IsRequired();
            HasRequired(p => p.Website).WithMany().HasForeignKey(p => p.WebSiteId).WillCascadeOnDelete(true);
        }
    }
}
