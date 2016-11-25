using Marketing.DataAccess;
using Marketing.DataAccess.Repositories;
using Marketing.Business.Models;
using Marketing.Business;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marketing.Business.Interface;
using Marketing.Business.Services;


namespace Marketing.Controllers
{
    public class HomeController : Controller
    {   public IModelManagementService _mapperService { get; set; }

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
            Marketing.Models.HeaderMenu model = new Marketing.Models.HeaderMenu();
            using (var repos = new ModelManagementRepository())
            {
                _mapperService = new ModelManagementService();
                model.Categories = _mapperService.MapCategoryToModel(repos.GetAllCategory());
                model.Stores = _mapperService.MapStoreToModel(repos.GetAllStore());
            }
            return View(model);
        }

        public ActionResult SetHeader() 
        {
            Marketing.Models.HeaderMenu model = new Marketing.Models.HeaderMenu();
            using (var repos = new ModelManagementRepository())
            {
                _mapperService = new ModelManagementService();
                model.Categories = _mapperService.MapCategoryToModel(repos.GetAllCategory());
                model.Stores = _mapperService.MapStoreToModel(repos.GetAllStore());
            }
            return View("_SetHeader", model);
        }
        public ActionResult Stores()
        {
            Store model = new Store();
            var _modelmanagementservice = new ModelManagementService();
            var Stores = new List<Store>();
            using ( var repos = new ModelManagementRepository())
            {
                Stores = _modelmanagementservice.MapStoreToModel(repos.GetAllStore()).ToList();                
            }
            return View(Stores);
        }
        public ActionResult Categories()
        {

            Category model = new Category();
            var _modelmanagementservice = new ModelManagementService();
            var Category = new List<Category>();
            using ( var repos = new ModelManagementRepository())
            {
                Category = _modelmanagementservice.MapCategoryToModel(repos.GetAllCategory()).ToList();                
            }
            return View(Category);
           

            
        }
        public ActionResult Promotions()
        {

            Promotion model = new Promotion();
            var _modelmanagementservice = new ModelManagementService();
            var Promotions = new List<Promotion>();
            using (var repos = new ModelManagementRepository())
            {
                Promotions = _modelmanagementservice.MapPromotionToModel(repos.GetAllPromotion()).ToList();
            }
            return View(Promotions);



        }
        public ActionResult fb()
        {
           
            return View();
        }


    }
}
