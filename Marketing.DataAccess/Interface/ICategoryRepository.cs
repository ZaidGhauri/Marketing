using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface ICategoryRepository : IWriteRepository
    {
        Category FindById(int Id);
        IList<Category> All();
    }
}