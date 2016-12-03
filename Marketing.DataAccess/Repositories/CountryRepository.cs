using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class CountryRepository : WriteRepository<Context>, ICountryRepository
    {
        public IEnumerable<Country> All()
        {
            return Context.Country.Where(a => a.IsActive).ToList();
        }
    }
}
