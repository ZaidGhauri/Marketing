using Marketing.Business.Models;
using System;
using System.Collections.Generic;


namespace Marketing.Business.Interface
{
    public interface IModelManagementService 
    {
        IList<Store> MapStoresToModel(IList<Marketing.Data.Store> stores);
        IList<Category> MapCategoriesToModel(IList<Marketing.Data.Category> categories);
        IList<Coupon> MapCouponsToModel(IList<Marketing.Data.Coupon> coupons);
        IList<Promotion> MapPromotionsToModel(IList<Data.Promotion> promotions);
        IList<Store> GetStoreDetail(int id);
        Category MapCategoryToModel(Data.Category category);
        Store MapStoreToModel(Data.Store store);

        Coupon MapCouponToModel(Data.Coupon coupon);
        Promotion MapPromotionToModel(Data.Promotion promotion);
        User MapUserToModel(Data.User user);
        IList<User> MapUsersToModel(List<Data.User> users);
    }
}
