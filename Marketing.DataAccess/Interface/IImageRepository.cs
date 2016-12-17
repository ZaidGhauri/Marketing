using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface IImageRepository : IWriteRepository
    {
        Image FindById(int Id);
        IList<Image> All();
    }
}