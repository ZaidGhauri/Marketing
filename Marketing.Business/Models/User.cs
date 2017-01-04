using Marketing.Common;
using Marketing.Data;
using System;
using System.Collections.Generic;
namespace Marketing.Business.Models
{
    public class User : DomainObject
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string CountryName { get; set; }
        public string IsNewsLetter { get; set; }
        public bool IsAdmin { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string WebSiteName { get; set; }
        public int WebSiteId { get; set; }
        public virtual WebSite WebSite { get; set; }
    }
}
