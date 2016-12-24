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
using Marketing.DataAccess.Interface;
namespace Marketing.Controllers
{
    public class HomeController : BaseController
    {
        public IStoreRepository storeRepository { get; set; }
        public ICategoryRepository categoryRepository { get; set; }
        public ICouponRepository couponRepository { get; set; }
        public IPromotionRepository promotionRepository { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Stores()
            {
                _mapperService = new ModelManagementService();
            var Stores = new List<Store>();
            using (storeRepository = new StoreRepository())
            {
                Stores = _mapperService.MapStoresToModel(storeRepository.All()).ToList();
            }
            return View(Stores);
        }
        public ActionResult Categories()
        {

            Category model = new Category();
            _mapperService = new ModelManagementService();
            var Category = new List<Category>();
            using (categoryRepository = new CategoryRepository())
            {
                Category = _mapperService.MapCategoriesToModel(categoryRepository.All()).ToList();
            }
            return View(Category);
           

            
        }
        public ActionResult Promotions()
        {
            Promotion model = new Promotion();
            _mapperService = new ModelManagementService();
            var Promotions = new List<Promotion>();
            using (promotionRepository = new PromotionRepository())
            {
                Promotions = _mapperService.MapPromotionsToModel(promotionRepository.All()).ToList();
            }
            return View(Promotions);
        }
        public ActionResult fb()
        {
           
            return View();
        }
    }
}
