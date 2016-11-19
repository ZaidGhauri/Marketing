
namespace Marketing.Data
{
   public class Coupon
   {
       public int CouponId { get; set; }

       public string Name { get; set; }

       public string ShortDescription { get; set; }

       public string FullDescription { get; set; }
       public bool IsFeaturedCoupon { get; set; }

       public bool ShowOnHome { get; set; }

       public bool AllowCustomerReviews { get; set; }

       public int RatingSum { get; set; }

       public int TotalReviews { get; set; }

       public int ManufacturerNo { get; set; }
       public string DisplayOrder { get; set; }

       public bool Published { get; set; }
       public string UpdatedBy { get; set; }

       public string CreatedBy { get; set; }

       public string Deleted { get; set; }

       public string Created { get; set; }

       public string Updated { get; set; }

       public int CategoryId { get; set; }

       public int StoreId { get; set; }

       public int Id { get; set; }

    }
}
