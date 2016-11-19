using System.Collections.Generic;

namespace Marketing.Data
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }

        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
