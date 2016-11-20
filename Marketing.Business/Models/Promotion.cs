using Marketing.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Business.Models
{
    public class Promotion : DomainObject
    {
        public Promotion()
        {
            Coupons = new List<Coupon>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Coupon> Coupons { get; set; }
    }
}
