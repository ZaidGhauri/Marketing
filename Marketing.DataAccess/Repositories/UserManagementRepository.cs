using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class UserManagementRepository : WriteRepository<Context>, IUserManagementRepository
    {
        public User ValidUser(string UserName, string Password, int WebSiteId)
        {
            return Context.User.Where(a => a.IsActive && a.Name == UserName && a.Password == Password && a.WebSiteId == WebSiteId).ToList().FirstOrDefault();
        }
        public List<User> All()
        {
            return Context.User.Where(a => a.IsActive).ToList();
        }
    }
}
