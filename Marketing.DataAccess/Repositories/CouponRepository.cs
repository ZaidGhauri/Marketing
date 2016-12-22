using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Interface
{
    public class CouponRepository : WriteRepository<Context>, ICouponRepository
    {
        public Coupon FindById(int Id)
        {
            return Context.Coupon.Where(a => a.IsActive && a.Id == Id).FirstOrDefault();
        }
        public IList<Coupon> All()
        {
            return Context.Coupon.Where(a => a.IsActive).OrderBy(z => z.Name).ToList();
        }
    }
}
