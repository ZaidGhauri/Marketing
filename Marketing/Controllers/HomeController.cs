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
            return View();
        }

        public ActionResult ImageUpload()
        {
            return View();
        }


         [HttpPost]
        public ActionResult ImageUpload(HttpPostedFileBase file)
        {
            try
            {
                /*Geting the file name*/
                string filename = System.IO.Path.GetFileName(file.FileName);
                /*Saving the file in server folder*/
                file.SaveAs(Server.MapPath("~/Picture/" + filename));
                string filepathtosave = "Picture/" + filename;
                /*Storing image path to show preview*/
                ViewBag.ImageURL = filepathtosave;
                /*
                 * HERE WILL BE YOUR CODE TO SAVE THE FILE DETAIL IN DATA BASE
                 *
                 */

                ViewBag.Message = "File Uploaded successfully.";
            }
            catch
            {
                ViewBag.Message = "Error while uploading the files.";
            }
            return View();
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
            return View("/shared/_menu", model);
        }
        public ActionResult Stores()
        {
            Store model = new Store();
            var _modelmanagementservice = new ModelManagementService();
            var Stores = new List<Store>();
            using (var repos = new StoreManagementRepository())
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
            using (var repos = new CategoryManagementRepository())
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
