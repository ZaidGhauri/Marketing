using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class StoreManagementRepository : WriteRepository<Context>, IStoreManagementRepository
    {
        public IList<Store> GetAllStore()
        {
            return Context.Stores.OrderBy(z => z.Name).ToList();
        }
        public Store GetStoreDetail(int id)
        {
            return Context.Stores.FirstOrDefault(one => one.Id == id);
        }
        public Store FindById(int id)
        {
            return Context.Stores.FirstOrDefault(one => one.Id == id);
        }
    }
}
