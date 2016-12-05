using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class PromotionRepository : WriteRepository<Context>, IPromotionRepository
    {
        public Promotion FindById(int Id)
        {
            return Context.Promotion.FirstOrDefault(a => a.IsActive && a.Id == Id);
        }
        public IList<Promotion> All()
        {
            return Context.Promotion.Where(a=>a.IsActive).OrderBy(z => z.Name).ToList();
        }
    }
}
