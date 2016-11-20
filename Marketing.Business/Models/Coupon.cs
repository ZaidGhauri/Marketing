﻿using Marketing.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Marketing.Business.Models
{
    public class Coupon : DomainObject
    {
        public Coupon()
        {
            Promotions = new List<Promotion>();
        }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool IsFeatured { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public int RatingSum { get; set; }
        public int TotalReviews { get; set; }
        public int ManufacturerNo { get; set; }
        public string DisplayOrder { get; set; }
        public int? CategoryId { get; set; }
        public int? StoreId { get; set; }
        public int? TagId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Store Store { get; set; }
        public virtual Tag Tag { get; set; }
        public ICollection<Promotion> Promotions { get; set; }
    }
}
