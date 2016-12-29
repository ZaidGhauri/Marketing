using Marketing.Common;
using Marketing.Data;
using System.Collections.Generic;



namespace Marketing.Data
{
    public class Reviews : DomainObject
    {
       
        public int UserId { get; set; }

        public int CouponId { get; set; }
        public int Ratings { get; set; }
  
        public string Description { get; set; }
    }
}
