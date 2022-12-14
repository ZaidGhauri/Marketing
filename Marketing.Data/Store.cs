using Marketing.Common;
using System.Collections.Generic;

namespace Marketing.Data
{
    public class Store : DomainObject
    {
        public Store()
        {
            Coupons = new List<Coupon>();
        }
        public string Name { get; set; }
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
        public virtual WebSite WebSite { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public virtual IList<Coupon> Coupons { get; set; }
    }
}
