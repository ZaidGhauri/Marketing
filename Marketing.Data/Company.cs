using System.Collections.Generic;

namespace Marketing.Data
{
    public class Company
    {
        public Company()
        {
            Address = new Address();
        }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public Address Address { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
