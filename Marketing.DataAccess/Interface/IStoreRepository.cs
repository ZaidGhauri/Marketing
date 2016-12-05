using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IStoreRepository : IWriteRepository
    {
        Store FindById(int Id);
        IList<Store> All();
    }
}