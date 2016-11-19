using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class CompanyConfig : EntityTypeConfiguration<Company>
    {
        public CompanyConfig()
        {
            // Primary Key
            HasKey(t => t.CompanyId);

            // Properties
            Property(t => t.CompanyName).HasMaxLength(50).IsRequired();

            // Relationships
            HasMany(t => t.Contacts)
                .WithMany(t => t.Companies)
                .Map(m =>
                {
                    m.ToTable("ContactCompanies");
                    m.MapLeftKey("CompanyId");
                    m.MapRightKey("ContactId");
                });
        }
    }
}
