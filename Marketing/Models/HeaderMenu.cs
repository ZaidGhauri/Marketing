using Marketing.Business.Models;
using System.Collections.Generic;
namespace Marketing.Models
{
   public class HeaderMenu
   {
       public HeaderMenu()
       {
           Categories = new List<Category>();
           Stores = new List<Store>();
       }
       public virtual ICollection<Category> Categories { get; set; }
       public ICollection<Store> Stores { get; set; }
       public bool IsActive { get; set; }
    }
}
