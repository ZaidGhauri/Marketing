using Marketing.Business.Models;
using System;
using System.Collections.Generic;


namespace Marketing.Business.Interface
{
    public interface IModelManagementService 
    {
        IList<Store> MapStoreToModel(IList<Marketing.Data.Store> stores);
        IList<Category> MapCategoryToModel(IList<Marketing.Data.Category> categories);
        List<Category> GetCategory();

    }
}
