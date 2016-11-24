using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
   public  interface IModelManagementRepository : IWriteRepository
    {
       IList<Category> GetCategory(ICriteria criteria);

       // IEnumerable<Store> GetStore(ICriteria criteria);
        IList<Category> GetAllCategory();
        IList<Store> GetAllStore();
        Store GetStoreDetail(int id);

        Store FindById(int id);




    }
}