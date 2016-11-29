using AutoMapper;
using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.DataAccess.Interface;
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

        public IList<Promotion> MapPromotionToModel(IList<Data.Promotion> promotions)
        {
            IList<Promotion> lst = new List<Promotion>();
            foreach (var promo in promotions)
            {
                Promotion objPromo = new Promotion();
                objPromo.Name = promo.Name;
                lst.Add(objPromo);
            }
            return lst;
        }

        public IList<Store> GetStoreDetail(int id)
        {
            var store1 = new List<Marketing.Data.Store>();
            var store2 = new List<Marketing.Business.Models.Store>();
            foreach (var item in store1)
            {
                Store c = new Store();
                c.Name = item.Name;
                store2.Add(c);

            }
            return store2;
        }

      
    }
}