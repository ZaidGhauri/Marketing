using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
   public class Store
   {
        public Store()
        {
            WebSite = new WebSite();
        }
       
       public WebSite WebSite { get; set; }
       
       [StringLength(50)]
       [Display(Name = "Store Name")]
       [Required]
       public string StoreName { get; set; }
       public bool SSLEnabled { get; set; }

       public bool IsPopular { get; set; }

       public bool IsNew { get; set; }

       public string Url { get; set; }

       public int LanguageId { get; set; }

       public string CompanyName { get; set; }

       public int CompanyPhoneNo { get; set; }

       //key
       public int StoreId { get; set; }
       public int WebSiteId { get; set; }

       public int CompanyId { get; set; }

       //public int MyProperty { get{
       //    return SSLEnabled == true ? 12 : 14;
       //} }


       }
}
