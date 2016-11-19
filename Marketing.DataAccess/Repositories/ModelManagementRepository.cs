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
        public IEnumerable<Category> GetCategory(ICriteria criteria)
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
            return query;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return Context.Categories.OrderBy(one => one.CategoryName);
        }

        public IEnumerable<Store> GetAllStore()
        {
            return Context.Stores.OrderBy(one => one.StoreName);
        }

        //public IEnumerable<Category> GetStore(ICriteria criteria)
        //{
        //    IQueryable<Store> query = Context.Stores;
        //    if (criteria.IsSearch)
        //    {
        //        var value = criteria.GetFieldData(criteria.FilterColumn);
        //        if (criteria.FilterColumn == "StoreName")
        //        {
        //            query = query.Where(one => one.StoreName.Contains(value));
        //        }
        //        //else if (criteria.FilterColumn == "StoreId")
        //        //{
        //        //    query = query.Where(one => one.Categories.Contains(value));
        //        //}

        //    }
        //    if (criteria.SortColumn == "StoreName" && criteria.SortOrder == "asc")
        //    {
        //        query = query.OrderBy(one => one.StoreName);
        //    }
        //    else if (criteria.SortColumn == "StoreName" && criteria.SortOrder == "desc")
        //    {
        //        query = query.OrderByDescending(one => one.StoreName);
        //    }
        //    //else if (criteria.SortColumn == "LastName" && criteria.SortOrder == "asc")
        //    //{
        //    //    query = query.OrderBy(one => one.LastName);
        //    //}
        //    //else if (criteria.SortColumn == "LastName" && criteria.SortOrder == "desc")
        //    //{
        //    //    query = query.OrderByDescending(one => one.LastName);
        //    //}
        //    else
        //        query = query.OrderBy(one => one.StoreName);
        //    query = query.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize);
        //    return query.Select(one=>new Category
        //        {
        //            CategoryId = one.,
        //            StoreName = one.StoreName

        //        });
        //}

        public int GetTotalCategory()
        {
            return Context.Categories.Count();
        }

        public Category GetCategory(int id)
        {
            return Context.Categories.FirstOrDefault(one => one.CategoryId == id);
        }

        public Store GetStore(int id)
        {
            return Context.Stores.FirstOrDefault(one => one.StoreId == id);
        }

      
        public int GetTotalStore()
        {
            return Context.Stores.Count();
        }
    
    }
}
