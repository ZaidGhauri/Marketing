using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Business.Models
{
  public  class Promotion
    {
      public int PromotionId { get; set; }
      public string Name { get; set; }

      public string Description { get; set; }

      public string UpdatedBy { get; set; }

      public string CreatedBy { get; set; }

      public string Deleted { get; set; }

      public string Created { get; set; }

      public string Updated { get; set; }

      //key
      public int CouponId { get; set; }


    }
}
