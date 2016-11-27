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
        public bool IsValid(string UserName, string Password, int WebSiteId)
        {
            return Context.User.Where(a => a.Name == UserName && a.Password == Password && a.WebSiteId == WebSiteId).ToList().Any();
        }

        public User Register(string UserName, string Password, int WebSiteId, bool IsAdmin = false)
        {
            var model = Context.User.Add(new User()
            {
                Name = UserName,
                Password = Password,
                IsAdmin = IsAdmin,
                WebSiteId = WebSiteId
            });
            model.Id = Context.SaveChanges();
            return model;
        }
    }
}
