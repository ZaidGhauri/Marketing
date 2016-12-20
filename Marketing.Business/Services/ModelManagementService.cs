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
        public IList<Store> MapStoresToModel(IList<Marketing.Data.Store> stores)
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
        public IList<Category> MapCategoriesToModel(IList<Data.Category> categories)
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

        public IList<Promotion> MapPromotionsToModel(IList<Data.Promotion> promotions)
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
        public Category MapCategoryToModel(Data.Category category)
        {
            Category model = new Category();
            model.Name = category.Name;
            model.Published = category.Published;
            model.ShowOnHomePage = category.ShowOnHomePage;
            model.ParentCategoryId = 0;
            model.IsFeatured = category.IsFeatured;
            model.IncludeInTopMenu = category.IncludeInTopMenu;
            model.Description = category.Description;
            model.Deleted = category.Deleted;
            model.WebSiteId = category.WebSiteId;
            model.IsActive = category.IsActive;
            model.Created = category.Created;
            model.CreatedBy = category.CreatedBy;
            model.Modified = category.Modified;
            model.ModifiedBy = category.ModifiedBy;
            return model;
        }
        public Store MapStoreToModel(Data.Store store)
        {
            Store model = new Store();
            model.Name = store.Name;
            model.Published = store.Published;
            model.ShowOnHomePage = store.ShowOnHomePage;
            store.CompanyId = 0;
            store.CompanyName = store.CompanyName;
            store.CompanyPhoneNo = store.CompanyPhoneNo;
            store.IsNew = store.IsNew;
            store.IsPopular = store.IsPopular;
            store.IsFeatured = model.IsFeatured;
            model.IncludeInTopMenu = store.IncludeInTopMenu;
            model.Deleted = store.Deleted;
            model.WebSiteId = store.WebSiteId;
            model.IsActive = store.IsActive;
            model.Created = store.Created;
            model.CreatedBy = store.CreatedBy;
            model.Modified = store.Modified;
            model.ModifiedBy = store.ModifiedBy;
            return model;
        }
        public Coupon MapCouponToModel(Data.Coupon coupon)
        {
            Coupon model = new Coupon();
            model.Name = coupon.Name;
            model.Published = coupon.Published;
            model.ShowOnHomePage = coupon.ShowOnHomePage;
            coupon.IsFeatured = model.IsFeatured;
            model.IncludeInTopMenu = coupon.IncludeInTopMenu;
            model.Deleted = coupon.Deleted;
            model.IsActive = coupon.IsActive;
            model.Created = coupon.Created;
            model.CreatedBy = coupon.CreatedBy;
            model.Modified = coupon.Modified;
            model.ModifiedBy = coupon.ModifiedBy;
            model.AllowCustomerReviews = coupon.AllowCustomerReviews;
            model.TotalReviews = coupon.TotalReviews;
            model.ManufacturerNo = coupon.ManufacturerNo;
            model.CategoryId = 0;
            model.StoreId = 0;
            model.TagId = 0;
            return model;
        }


        public Promotion MapPromotionToModel(Data.Promotion promotion)
        {
            Promotion model = new Promotion();
            model.Name = promotion.Name;
            model.Id = promotion.Id;
            model.Description = promotion.Description;
            model.Created = promotion.Created;
            model.IsActive = promotion.IsActive;
            model.Modified = promotion.Modified;
            model.ModifiedBy = promotion.ModifiedBy;
          return model;
        }
    }
}