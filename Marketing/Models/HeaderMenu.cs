using System.Collections.Generic;


namespace Marketing.Business.Models
{
   public class HeaderMenu
   {
       public virtual ICollection<Category> Categories { get; set; }
       public List<Store> Stores { get; set; }

       public bool IsActive { get; set; }



    }
}
