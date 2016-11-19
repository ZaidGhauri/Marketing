using System.Collections.Generic;

namespace Marketing.Data
{
   public class Store
   {  public Store()
        {
            WebSite w = new WebSite();
        }
       public int StoreId { get; set; }

       public string StoreName { get; set; }
       public bool SSLEnabled { get; set; }

       public bool IsPopular { get; set; }

       public bool IsNew { get; set; }

       public string Url { get; set; }

       public int LanguageId { get; set; }

       public string CompanyName { get; set; }

       public int CompanyPhoneNo { get; set; }

       public int WebSiteId { get; set; }

       public int CompanyId { get; set; }
       public virtual ICollection<Category> Categories { get; set; }
    }
}
