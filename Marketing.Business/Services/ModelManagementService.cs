using AutoMapper;
using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Common;
using Marketing.DataAccess.Interface;
using StructureMap;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.Business.Services
{
    public class ModelManagementService : IModelManagementService
    {
        private System.Data.Entity.DbSet<Category> Category;
        public IEnumerable<Store> MapStoreToModel(List<Marketing.Data.Store> stores)
        {
            IList<Store> lst = new List<Store>();
            foreach (var store in stores)
            {
                Store objStore = new Store();
                objStore.StoreName = store.StoreName;
                lst.Add(objStore);
            }
            return lst;
        }

        public List<Category> GetCategory()
        {
            var cat1 = new List<Marketing.Data.Category>();
            var cat2 = new List<Marketing.Business.Models.Category>();
            foreach (var item in cat1)
            {
                Category c = new Category();
                c.CategoryName = item.CategoryName;
                cat2.Add(c);
             
            }
            return cat2;
        }


    }
}