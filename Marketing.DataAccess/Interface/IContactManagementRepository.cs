using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IContactManagementRepository : IWriteRepository
    {
        IEnumerable<ContactType> GetContactTypes(ICriteria criteria);

        IEnumerable<ContactInfo> GetContacts(ICriteria criteria);

        int GetTotalContactTypes();

        ContactType GetContactType(int id);
        
        Contact GetContact(int id);

        int GetTotalContacts();

        IEnumerable<ContactType> GetAllContactTypes();
    }
}
