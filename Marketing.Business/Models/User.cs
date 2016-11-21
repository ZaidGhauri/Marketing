using Marketing.Common;
using System.Collections.Generic;
namespace Marketing.Business.Models
{
    public class User : DomainObject
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int WebSiteId { get; set; }
        public virtual WebSite WebSite { get; set; }
    }
}
