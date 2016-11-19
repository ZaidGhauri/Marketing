using Marketing.Business.Models;
using Marketing.Common;
using System;
using System.Collections.Generic;


namespace Marketing.Business.Interface
{
    public interface IModelManagementService 
    {
        IEnumerable<Store> MapStoreToModel(List<Marketing.Data.Store> stores);

        List<Category> GetCategory();

    }
}
