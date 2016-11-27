using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class CouponConfig : EntityTypeConfiguration<Coupon>
    {
       public CouponConfig() 
       {   // Primary Key
            HasKey(c => c.Id);

            // Properties
            Property(c => c.Name).HasMaxLength(50).IsRequired();

            HasOptional(p => p.Store).WithMany().HasForeignKey(p => p.StoreId).WillCascadeOnDelete(false);
            HasOptional(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(false);
            HasOptional(p => p.Tag).WithMany().HasForeignKey(p => p.TagId).WillCascadeOnDelete(false);
            // Relationships
            HasRequired(p => p.Picture).WithMany().HasForeignKey(p => p.PictureId).WillCascadeOnDelete(false);
            HasMany(p => p.Promotions)
                .WithMany(p=>p.Coupons)
                .Map(m =>
                {
                    m.ToTable("PromotionCoupons");
                    m.MapLeftKey("PromotionId");
                    m.MapRightKey("StoreId");
                });
       }

    }
}
