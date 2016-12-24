using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Marketing.Controllers
{
    public class BaseController : Controller
    {
        public static WebSite WebSite { get; set; }
        public string AppWebSiteName { get; set; }
        public IWebSiteRepository websiteRepo{ get; set; }
        public IModelManagementService _mapperService { get; set; }
        public BaseController()
        {
            getWebSite();
            setHeader();
            //checkUserLogin();
        }

        //private void checkUserLogin()
        //{
        //    if (Session == null || Session["UName"] == null)
        //    {
        //        Response.Redirect("/User/LoginError");
        //    }
        //}

        private void getWebSite()
        {
            AppWebSiteName = System.Configuration.ConfigurationManager.AppSettings["WebSiteName"];
            using (websiteRepo = new WebSiteRepository())
            {
                var web = websiteRepo.FindWebsiteByName(AppWebSiteName);
                if (WebSite == null) WebSite = new WebSite();
                if (web != null)
                {
                    WebSite.Id = web.Id;
                    WebSite.Name = web.Name;
                    WebSite.Url = web.Url;
                }
            }
        }
        private void setHeader()
        {
            Marketing.Models.HeaderMenu model = new Marketing.Models.HeaderMenu();
            using (var categoryRepo = new CategoryRepository())
            using (var storeRepo = new StoreRepository())
            {
                _mapperService = new ModelManagementService();
                model.Categories = _mapperService.MapCategoriesToModel(categoryRepo.All());
                model.Stores = _mapperService.MapStoresToModel(storeRepo.All());
                ViewBag.HeaderMenu = model;
            }
        }
    }
}
