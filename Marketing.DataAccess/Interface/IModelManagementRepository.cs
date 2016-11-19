using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
   public  interface IModelManagementRepository : IWriteRepository
    {
        IEnumerable<Category> GetCategory(ICriteria criteria);

       // IEnumerable<Store> GetStore(ICriteria criteria);
        IEnumerable<Category> GetAllCategory();
        IEnumerable<Store> GetAllStore();
       
        Category GetCategory(int id);
        
        Store GetStore(int id);

        int GetTotalStore();
        int GetTotalCategory();

       
      
    }
}