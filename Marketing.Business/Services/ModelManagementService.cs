using AutoMapper;
using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.DataAccess.Interface;
using StructureMap;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Marketing.Business.Services
{
    public class ModelManagementService : IModelManagementService
    {
     
        public IList<Category> MapCategoriesToModel(IList<Data.Category> categories)
        {
            IList<Category> lst = new List<Category>();
            foreach (var category in categories)
            {
                Category objCategory = new Category();
                objCategory.Name = category.Name;
                objCategory.Id = category.Id;
                objCategory.Image = category.Image;
                objCategory.Description = category.Description;
                objCategory.Published = category.Published;
                objCategory.ShowOnHomePage = category.ShowOnHomePage;
                objCategory.ParentCategoryId = category.ParentCategoryId;
                objCategory.IsFeatured = category.IsFeatured;
                objCategory.IncludeInTopMenu = category.IncludeInTopMenu;
                objCategory.ImagePath = Path.Combine("/Storage/Images", category.Image.Name);
                objCategory.Deleted = category.Deleted;
                objCategory.WebSiteId = category.WebSiteId;
                objCategory.IsActive = category.IsActive;
                objCategory.Created = category.Created;
                objCategory.CreatedBy = category.CreatedBy;
                objCategory.Modified = category.Modified;
                objCategory.ModifiedBy = category.ModifiedBy;
                objCategory.Coupons = MapCouponsToModel(category.Coupons);
                objCategory.Stores = MapStoresToModel(category.Coupons.Any(a=>a.StoreId.HasValue) ? category.Coupons.Select(a => a.Store).ToList() : null);
                lst.Add(objCategory);
            }
            return lst;
        }
        public Category MapCategoryToModel(Data.Category category)
        {
            Category model = new Category();
            model.Name = category.Name;
            model.Published = category.Published;
            model.ShowOnHomePage = category.ShowOnHomePage;
            model.ParentCategoryId = category.ParentCategoryId;
            model.IsFeatured = category.IsFeatured;
            model.IncludeInTopMenu = category.IncludeInTopMenu;
            model.Description = category.Description;
            model.ImagePath = Path.Combine("/Storage/Images", category.Image.Name);
            model.Deleted = category.Deleted;
            model.WebSiteId = category.WebSiteId;
            model.IsActive = category.IsActive;
            model.Created = category.Created;
            model.CreatedBy = category.CreatedBy;
            model.Modified = category.Modified;
            model.ModifiedBy = category.ModifiedBy;
            model.Coupons = MapCouponsToModel(category.Coupons);
            model.Stores = MapStoresToModel(category.Coupons.Any(a => a.StoreId.HasValue) ? category.Coupons.Select(a => a.Store).ToList() : null);

            return model;
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
        public IList<Store> MapStoresToModel(IList<Marketing.Data.Store> stores)
        {
            IList<Store> lst = new List<Store>();
            if (stores != null)
            {
                foreach (var store in stores)
                {
                    Store objStore = new Store();
                    objStore.Name = store.Name;
                    objStore.Id = store.Id;
                    objStore.Published = store.Published;
                    objStore.ShowOnHomePage = store.ShowOnHomePage;
                    objStore.IsFeatured = store.IsFeatured;
                    objStore.IncludeInTopMenu = store.IncludeInTopMenu;
                    objStore.ImagePath = Path.Combine("/Storage/Images", store.Image.Name);
                    objStore.Deleted = store.Deleted;
                    objStore.WebSiteId = store.WebSiteId;
                    objStore.IsActive = store.IsActive;
                    objStore.Created = store.Created;
                    objStore.CreatedBy = store.CreatedBy;
                    objStore.Modified = store.Modified;
                    objStore.ModifiedBy = store.ModifiedBy;
                    lst.Add(objStore);
                }   
            }
            return lst;
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
            model.ImagePath = Path.Combine("/Storage/Images", store.Image.Name);
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
            model.Coupons = MapCouponsToModel(store.Coupons);
            model.Categories = MapCategoriesToModel(store.Coupons.Any(a => a.CategoryId.HasValue) ? store.Coupons.Select(a => a.Category).ToList() : null);
            return model;
        }
        public IList<Coupon> MapCouponsToModel(IList<Data.Coupon> coupons)
        {
            IList<Coupon> lst = new List<Coupon>();
            foreach (var coupon in coupons)
            {
                Coupon objCoupon = new Coupon();
                objCoupon.Name = coupon.Name;
                objCoupon.Id = coupon.Id;
                objCoupon.Name = coupon.Name;
                objCoupon.Published = coupon.Published;
                objCoupon.ShowOnHomePage = coupon.ShowOnHomePage;
                objCoupon.ShortDescription = coupon.ShortDescription;
                objCoupon.FullDescription = coupon.FullDescription;
                objCoupon.IsFeatured = coupon.IsFeatured;
                objCoupon.IncludeInTopMenu = coupon.IncludeInTopMenu;
                objCoupon.Deleted = coupon.Deleted;
                objCoupon.IsActive = coupon.IsActive;
                objCoupon.Created = coupon.Created;
                objCoupon.CreatedBy = coupon.CreatedBy;
                objCoupon.Modified = coupon.Modified;
                objCoupon.ModifiedBy = coupon.ModifiedBy;
                objCoupon.AllowCustomerReviews = coupon.AllowCustomerReviews;
                objCoupon.TotalReviews = coupon.TotalReviews;
                objCoupon.ManufacturerNo = coupon.ManufacturerNo;
                objCoupon.CategoryId = coupon.CategoryId;
                objCoupon.StoreId = coupon.StoreId;
                objCoupon.TagId = coupon.TagId;
                objCoupon.RatingSum = coupon.RatingSum;
                objCoupon.ImagePath = Path.Combine("/Storage/Images", coupon.Image.Name);
                lst.Add(objCoupon);
            }
            return lst;
        }
        public Coupon MapCouponToModel(Data.Coupon coupon)
        {
            Coupon model = new Coupon();
            model.Id = coupon.Id;
            model.Name = coupon.Name;
            model.Published = coupon.Published;
            model.ShowOnHomePage = coupon.ShowOnHomePage;
            coupon.IsFeatured = model.IsFeatured;
            model.ShortDescription = coupon.ShortDescription;
            model.FullDescription = coupon.FullDescription;
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
            model.RatingSum = coupon.RatingSum;
            model.ImagePath = Path.Combine("/Storage/Images", coupon.Image.Name);
            model.CategoryId = 0;
            model.StoreId = 0;
            model.TagId = 0;
            return model;
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


        public User MapUserToModel(Data.User user)
        {
            User model = new User();
            model.Name = user.Name;
            model.Id = user.Id;
            model.Created = user.Created;
            model.IsActive = user.IsActive;
            model.Modified = user.Modified;
            model.ModifiedBy = user.ModifiedBy;
            return model;
        }

        public IList<User> MapUsersToModel(List<Data.User> users)
        {
            IList<User> lst = new List<User>();
            foreach (var user in users)
            {
                User objUser = new User();
                objUser.Name = user.Name;
                objUser.Address = user.Address;
                objUser.Email = user.Email;
                objUser.State = user.State;
                objUser.City = user.City;
                objUser.CountryName = user.Country != null ? user.Country.Name : "N/A";
                objUser.WebSiteName = user.WebSite != null ? user.WebSite.Name : "N/A";
                objUser.Gender = user.Gender;
                objUser.Phone = user.Phone;
                objUser.IsNewsLetter = user.IsNewsLetter == true ? "True" : "False";
                lst.Add(objUser);
            }
            return lst;
        }
    }
}