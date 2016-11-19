using System.Collections.Generic;


namespace Marketing.Data
{
   public class HeaderMenu
   {
       public virtual ICollection<Category> Categories { get; set; }
       public List<Store> Stores { get; set; }

       public bool IsActive { get; set; }



    }
}
