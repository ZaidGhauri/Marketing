using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Business.Models
{
  public  class HeaderMenu
    {   public List<Category> Categories { get; set; }
        public List<Store> Stores { get; set; }

        public bool IsActive { get; set; }


        public HeaderMenu()
        {
            Categories = new List<Category>();
            Stores = new List<Store>();

    
    }
    }
}
