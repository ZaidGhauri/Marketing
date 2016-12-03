using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IPromotionRepository : IWriteRepository
    {
        Promotion FindById(int Id);
        IList<Promotion> All();
    }
}