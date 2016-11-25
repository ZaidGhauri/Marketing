using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Data;


namespace Marketing.Data
{
    public class UserClass
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int WebSiteId { get; set; }
        public int CountryId { get; set; }
        public virtual WebSite WebSite { get; set; }
        public virtual Country Country { get; set; }
    }
}
