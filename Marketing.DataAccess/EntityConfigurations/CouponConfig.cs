using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class CouponConfig : EntityTypeConfiguration<Coupon>
    {
       public CouponConfig() 
       {   // Primary Key
            HasKey(c => c.CouponId);

            // Properties
            Property(c => c.Name).HasMaxLength(30).IsRequired();

         
       }

    }
}
