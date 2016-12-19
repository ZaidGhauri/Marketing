using Marketing.Business.Models;
using System;
using System.Collections.Generic;


namespace Marketing.Business.Interface
{
    public interface IModelManagementService 
    {
        IList<Store> MapStoresToModel(IList<Marketing.Data.Store> stores);
        IList<Category> MapCategoriesToModel(IList<Marketing.Data.Category> categories);

        IList<Promotion> MapPromotionsToModel(IList<Data.Promotion> promotions);
        IList<Store> GetStoreDetail(int id);
        Category MapCategoryToModel(Data.Category category);
        Store MapStoreToModel(Data.Store store);

        Coupon MapCouponToModel(Data.Coupon coupon);
    }
}
