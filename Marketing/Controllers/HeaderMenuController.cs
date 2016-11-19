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
    public class HeaderMenuController : Controller
    {
        public IModelManagementService _mapperService { get; set; }
        public IModelManagementService _categoryService { get; set; }
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
    }
}
