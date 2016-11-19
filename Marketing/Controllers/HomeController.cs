using Marketing.Business.Interface;
using Marketing.Business.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Marketing.Business.Mappings;
using Marketing.DataAccess.Repositories;
using System.Collections.Generic;


namespace Marketing.Controllers
{
    public class HomeController : Controller
    {
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
           
            // var s = _managementService.GetAllContactTypes();
            //using (var repos = new ContactManagementRepository())
            //{
            //var f = repos.GetAllContactTypes().ToList().FirstOrDefault();
            //f.IsActive = model.IsActive;
            //}
            return View();

           // Marketing.Data.Website web = new Marketing.Data.Category();
            
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
