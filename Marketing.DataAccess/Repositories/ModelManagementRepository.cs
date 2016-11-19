using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.DataAccess.Repositories
{
   public  class ModelManagementRepository : WriteRepository<Context>, IModelManagementRepository
    {
       public IList<Category> GetCategory(ICriteria criteria)
        {
            IQueryable<Category> query = Context.Categories;
            if (criteria.IsSearch)
            {
                var value = criteria.GetFieldData(criteria.FilterColumn);
                query = query.Where(one => one.CategoryName.Contains(value));
            }
            if (criteria.SortColumn == "Name" && criteria.SortOrder == "asc")
            {
                query = query.OrderBy(one => one.CategoryName);
            }
            else if (criteria.SortColumn == "Name" && criteria.SortOrder == "desc")
            {
                query = query.OrderByDescending(one => one.CategoryName);
            }
            else
                query = query.OrderBy(one => one.CategoryName);
            query = query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
            return query.ToList();
        }
        public IList<Category> GetAllCategory()
        {
            return Context.Categories.OrderBy(one => one.CategoryName).ToList();
        }
        public IList<Store> GetAllStore()
        {
            return Context.Stores.OrderBy(one => one.StoreName).ToList();
        }
        //public void Dispose()
        //{
        //    Context.Dispose();
        //}
    }
}
