using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface ICategoryManagementRepository : IWriteRepository
    {
        IList<Category> GetCategory(ICriteria criteria);
        IList<Category> GetAllCategory();
        Category FindById(int id);


    }
}
   
