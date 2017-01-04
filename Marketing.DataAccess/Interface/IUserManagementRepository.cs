using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IUserManagementRepository : IWriteRepository
    {
        User ValidUser(string UserName, string Password, int WebSiteId);
        List<User> All();
    }
}