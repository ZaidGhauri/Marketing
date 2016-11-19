using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
  public class CategoryConfig : EntityTypeConfiguration<Category>
    {
      public CategoryConfig(){
            // Primary Key
            HasKey(cat => cat.CategoryId);

            // Properties
            Property(cat => cat.CategoryName).HasMaxLength(50).IsRequired();

            // Relationships
            HasMany(cat => cat.Store)
                .WithMany(cat => cat.Categories)
                .Map(m =>
                {
                    m.ToTable("Stores");
                    m.MapLeftKey("CategoryId");
                    m.MapRightKey("StoreId");
                });
      }
    }
}
