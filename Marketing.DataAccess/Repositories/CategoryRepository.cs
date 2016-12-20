using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class CategoryRepository : WriteRepository<Context>, ICategoryRepository
    {
        public Category FindById(int Id)
        {
            return Context.Categories.Where(a=>a.IsActive && a.Id == Id).FirstOrDefault();
        }
        public IList<Category> All()
        {
            return Context.Categories.Where(a => a.IsActive).OrderBy(z => z.Name).ToList();
        }
        public int FindByName(string Name)
        {
            var category = Context.Categories.Where(a => a.IsActive && a.Name == Name).FirstOrDefault();
            if (category != null) return category.Id;
            else return 0;
        }
    }
}
