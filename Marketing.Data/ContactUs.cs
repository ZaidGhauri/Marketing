using Marketing.Common;
using System;
using System.Collections.Generic;
namespace Marketing.Data
{
    public class ContactUs : DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comments { get; set; }
        public int WebSiteId { get; set; }
        public int? CountryId { get; set; }
        public virtual WebSite WebSite { get; set; }
        public virtual Country Country { get; set; }
    }
}
