using System.Collections.Generic;

namespace Marketing.Data
{
   public class Category 
   {
       public Category()
        {
            WebSite w = new WebSite();
        }
       public int CategoryId { get; set; }
       public string CategoryName { get; set; }

       public string Description { get; set; }

       public string Collection { get; set; }

       public int PictureId { get; set; }

       public bool IsActive { get; set; }

       public bool ShowOnHome { get; set; }

       public bool InTopMenu { get; set; }

       public bool Published { get; set; }
       public string UpdatedBy { get; set; }

       public string CreatedBy { get; set; }

       public string Deleted { get; set; }

       public string Created { get; set; }

       public string Updated { get; set; }
       public ICollection<Store> Store { get; set; }


    }
}
