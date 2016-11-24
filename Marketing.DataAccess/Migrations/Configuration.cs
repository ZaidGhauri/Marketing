namespace Marketing.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.WebSite.AddOrUpdate(
              p => p.Id,
              new Marketing.Data.WebSite
              {
                  Name = "Get Coupon",
                  Url = "www.getcoupon.com",
                  Created = Marketing.Common.DateTimeHelper.Now(),
                  Modified = Marketing.Common.DateTimeHelper.Now(),
                  CreatedBy = "Rowan Miller",
                  ModifiedBy = "Rowan Miller",
                  IsActive = true
              }
            );

        }
    }
}
