﻿using Marketing.Common;
using Marketing.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Marketing.Business.Models
{
    public class Category : DomainObject
    {
        public Category()
        {
            Categories = new List<SelectListItem>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public int ParentCategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public string type { get; set; }
        public int WebSiteId { get; set; }
        public virtual WebSite Website { get; set; }
        public List<SelectListItem> Categories { get; set; }

    }
}
