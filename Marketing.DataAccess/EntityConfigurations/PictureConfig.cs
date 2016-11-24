using System.Data.Entity.ModelConfiguration;
using Marketing.Data;

namespace Marketing.DataAccess.EntityConfigurations
{
   public class PictureConfig : EntityTypeConfiguration<Picture>
    {
       public PictureConfig()
       {
           // Primary Key
           HasKey(pic => pic.Id);
   }




    }
}
