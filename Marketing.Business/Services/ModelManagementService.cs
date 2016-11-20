using AutoMapper;
using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.DataAccess.Interface;
using StructureMap;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.Business.Services
{
    public class ModelManagementService : IModelManagementService
    {
        public IList<Store> MapStoreToModel(IList<Marketing.Data.Store> stores)
        {
            IList<Store> lst = new List<Store>();
            foreach (var store in stores)
            {
                Store objStore = new Store();
                objStore.Name = store.Name;
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
                c.Name = item.Name;
                cat2.Add(c);
             
            }
            return cat2;
        }




        public IList<Category> MapCategoryToModel(IList<Data.Category> categories)
        {
            IList<Category> lst = new List<Category>();
            foreach (var category in categories)
            {
                Category objCategory = new Category();
                objCategory.Name = category.Name;
                lst.Add(objCategory);
            }
            return lst;
        }
    }
}