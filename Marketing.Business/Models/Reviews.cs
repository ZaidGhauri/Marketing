using Marketing.Common;
using Marketing.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Marketing.Business.Models
{
    public class ReviewModel : DomainObject
    {
       
        public int UserId { get; set; }

        public int CouponId { get; set; }
  
        public int Ratings { get; set; }
        [Required]

        public string Description { get; set; }
        
    }
}
