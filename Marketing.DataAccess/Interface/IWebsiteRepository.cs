using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IWebSiteRepository : IWriteRepository
    {
        int FindIdByName(string UserName);
        WebSite FindWebsiteByName(string Name);
    }
}