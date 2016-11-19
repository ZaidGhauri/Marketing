using Marketing.Business.Models;
using Marketing.Common;
using System;
using System.Collections.Generic;

namespace Marketing.Business.Interface
{
    public interface IContactManagementService : IDisposable
    {
        IEnumerable<ContactType> GetContactTypes(ICriteria criteria);

        IEnumerable<ContactType> GetAllContactTypes();

        int GetTotalContactTypes();
    }
}
