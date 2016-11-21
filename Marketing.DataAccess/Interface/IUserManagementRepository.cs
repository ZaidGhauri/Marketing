using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IUserManagementRepository : IWriteRepository
    {
        bool IsValid(string UserName, string Password);
        User Register(string UserName, string Password, bool IsAdmin, int WebsiteId = 1);
    }
}