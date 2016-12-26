using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class CouponRepository : WriteRepository<Context>, ICouponRepository
    {
        public Coupon FindById(int Id)
        {
            return Context.Coupon.Where(a => a.IsActive && a.Id == Id).FirstOrDefault();

        }
    }
}
