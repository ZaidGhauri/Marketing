using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IStoreManagementRepository : IWriteRepository
    {
        IList<Store> GetAllStore();
        Store GetStoreDetail(int id);

        Store FindById(int id);




    }
}