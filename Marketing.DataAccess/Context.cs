using Marketing.Data;
using System.Data.Entity;
using Marketing.DataAccess.EntityConfigurations;

namespace Marketing.DataAccess
{
    public class Context : DbContext
    {
        public Context()
            : base("Name=MarketingCoupon")
        {
            
        }
        public DbSet<WebSite> WebSite { get; set; }

        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Promotion> Promotion { get; set; }

        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WebSiteConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new CountryConfig());
            modelBuilder.Configurations.Add(new ContactUsConfig());
            modelBuilder.Configurations.Add(new CategoryConfig());
            modelBuilder.Configurations.Add(new StoreConfig());
            modelBuilder.Configurations.Add(new CouponConfig());
            modelBuilder.Configurations.Add(new PromotionConfig());
            modelBuilder.Configurations.Add(new TagConfig());
         
        }
    }
}
