using Marketing.Common;
using System.Collections.Generic;

namespace Marketing.Data
{
    public class Category : DomainObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Collection { get; set; }
        public int PictureId { get; set; }
        public int ParentCategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int WebSiteId { get; set; }
        public virtual WebSite WebSite { get; set; }
    }
}
