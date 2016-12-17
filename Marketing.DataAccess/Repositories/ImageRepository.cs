using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Interface
{
    public class ImageRepository : WriteRepository<Context>, IImageRepository
    {
        public Image FindById(int Id)
        {
            return Context.Images.Where(a => a.IsActive && a.Id == Id).FirstOrDefault();
        }
        public IList<Image> All()
        {
            return Context.Images.Where(a => a.IsActive).OrderBy(z => z.Name).ToList();
        }
    }
}