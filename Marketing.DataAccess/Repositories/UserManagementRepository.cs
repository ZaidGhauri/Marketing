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
        public bool IsValid(string UserName, string Password)
        {
            return Context.User.Where(a => a.Name == UserName && a.Password == Password).ToList().Any();
        }

        public User Register(string UserName, string Password, bool IsAdmin, int WebsiteId = 1)
        {
            var model = Context.User.Add(new User()
            {
                Name = UserName,
                Password = Password,
                IsAdmin = IsAdmin,
                WebSiteId = WebsiteId
            });
            model.Id = Context.SaveChanges();
            return model;
        }
    }
}
