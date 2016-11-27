using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class WebSiteRepository : WriteRepository<Context>, IWebSiteRepository
    {
        public int FindIdByName(string Name)
        {
            var web = Context.WebSite.Where(a => a.Name == Name && a.IsActive).ToList().FirstOrDefault();
            if (web != null) return web.Id;
            else return 0;
        }
         
        public WebSite FindWebsiteByName(string Name)
        {
            var web = Context.WebSite.Where(a => a.Name == Name && a.IsActive).ToList().FirstOrDefault();
            if (web != null) return web;
            else return null;
        }
    }
}
