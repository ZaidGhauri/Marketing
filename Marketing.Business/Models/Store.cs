using Marketing.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
    public class Store : DomainObject
    {
        public Store()
        {
            Counpons = new List<Coupon>();
        }


         [Required]
         [Display(Name = "Store Name")]
        public string Name { get; set; }

         public string ImagePath { get; set; }
        public bool IsPopular { get; set; }
        public bool IsNew { get; set; }
        public string Url { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int CompanyPhoneNo { get; set; }
        public bool IsFeatured { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int WebSiteId { get; set; }
        public virtual WebSite Website { get; set; }

        public IList<Coupon> Counpons { get; set; }
    }
}
