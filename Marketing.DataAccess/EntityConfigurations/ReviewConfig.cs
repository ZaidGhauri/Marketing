using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class ReviewConfig : EntityTypeConfiguration<Reviews>
    {
        public ReviewConfig()
        {
            // Primary Key
            HasKey(rev => rev.Id);
            // Properties
           
        }
    }
}
