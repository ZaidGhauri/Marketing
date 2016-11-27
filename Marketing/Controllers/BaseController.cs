using Marketing.Business.Models;
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
        public BaseController()
        {
            getWebSite();
        }

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
    }
}
