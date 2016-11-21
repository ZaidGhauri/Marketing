using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
    public class TagConfig : EntityTypeConfiguration<Tag>
    {
        public TagConfig() 
       {   // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name).HasMaxLength(80).IsRequired();

         
       }
   
   
   
   }
}
