using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class StoreRepository : WriteRepository<Context>, IStoreRepository
    {
        public Store FindById(int Id)
        {
            return Context.Stores.FirstOrDefault(a => a.IsActive && a.Id == Id);
        }
        public IList<Store> All()
        {
            return Context.Stores.Where(a => a.IsActive).OrderBy(z => z.Name).ToList();
        }
    }
}
