using Marketing.Business.Interface;
using Marketing.Business.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Marketing.Business.Mappings;
using Marketing.DataAccess.Repositories;
using System.Collections.Generic;
using Marketing.Business.Services;


namespace Marketing.Controllers
{
    public class HomeController : Controller
    {
        public IModelManagementService _mapperService { get; set; }
        private readonly IModelManagementService _modelmanagementservice;
        //protected override object MapEntityToModel(Category category)
        //{
        //    return new
        //    {
        //        category.CategoryId,
        //        category.CategoryName,
                
        //    };
        //}

        //
        // GET: /Home/
        public ActionResult Index()
        {

            HeaderMenu model = new HeaderMenu();
            using (var repos = new ModelManagementRepository())
            {
                _mapperService = new ModelManagementService();
                model.Categories = _mapperService.MapCategoryToModel(repos.GetAllCategory());
                model.Stores = _mapperService.MapStoreToModel(repos.GetAllStore());
            }
            return View(model);
            
        }
        public ActionResult Stores()
        {
           
           
             var repos = new ModelManagementRepository();
             return View(repos.GetAllStore().ToList());
            
           
        }
        public ActionResult Categories()
        {

            Marketing.Business.Models.Category model = new Marketing.Business.Models.Category();
            var repos = new ModelManagementRepository();
            //var f = repos.GetAllCategory().ToList();
            var a = _modelmanagementservice.MapStoreToModel(repos.GetAllStore().ToList());
            return View(a);
           

            
        }
    }
}
