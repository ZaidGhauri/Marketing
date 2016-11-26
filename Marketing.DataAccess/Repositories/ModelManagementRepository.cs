using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
    public class ModelManagementRepository : WriteRepository<Context>, IModelManagementRepository
    {
        public IList<Category> GetCategory(ICriteria criteria)
        {
            IQueryable<Category> query = Context.Categories;
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(z => z.Name.Contains(value));
            }
            if (criteria.SortColumn == "Name" && criteria.SortOrder == "asc")
            {
                query = query.OrderBy(z => z.Name);
            }
            else if (criteria.SortColumn == "Name" && criteria.SortOrder == "desc")
            {
                query = query.OrderByDescending(z => z.Name);
            }
            else
                query = query.OrderBy(z => z.Name);
            query = query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
            return query.ToList();
        }
        public IList<Category> GetAllCategory()
        {
            return Context.Categories.OrderBy(z => z.Name).ToList();
        }
        public IList<Promotion> GetAllPromotion()
        {
            return Context.Promotion.OrderBy(z => z.Name).ToList();
        }
        public IList<Store> GetAllStore()
        {
            return Context.Stores.OrderBy(z => z.Name).ToList();
        }
        public Store GetStoreDetail(int id)
        {
            return Context.Stores.FirstOrDefault(one => one.Id == id);
        }
        public Store FindById(int id)
        {
            return Context.Stores.FirstOrDefault(one => one.Id == id);
        }
    }
}
