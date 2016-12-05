using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
using Marketing.Common;
using Marketing.DataAccess;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Marketing.Controllers
{
    public class StoreController : BaseController
    {
        //private IStoreRepository storeRepository;
        public IModelManagementService _mapperService { get; set; }
        public IStoreRepository storeRepository { get; set; }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var model = new Store();
            if (Id > 0)
            {
                _mapperService = new ModelManagementService();
                using (storeRepository = new StoreRepository())
                {
                    model = _mapperService.MapStoreToModel(storeRepository.FindById(Id));
                }
                }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Store model)
        {
            if (ModelState.IsValid)
            {
                using (storeRepository = new StoreRepository())
                {
                    var store = new Data.Store();
                    store.Name = model.Name;
                    store.Published = model.Published;
                    store.ShowOnHomePage = model.ShowOnHomePage;
                    store.CompanyId = 0;
                    store.CompanyName = store.CompanyName;
                    store.CompanyPhoneNo = store.CompanyPhoneNo;
                    store.IsNew = store.IsNew;
                    store.IsPopular = store.IsPopular;
                    store.IsFeatured = model.IsFeatured;
                    store.IncludeInTopMenu = model.IncludeInTopMenu;
                    store.Deleted = model.Deleted;
                    store.WebSiteId = WebSite.Id;
                    store.IsActive = model.IsActive;
                    store.Created = DateTimeHelper.Now();
                    store.CreatedBy = Session["UName"].ToString();
                    store.Modified = DateTimeHelper.Now();
                    store.ModifiedBy = Session["UName"].ToString(); ;
                    if (model.Id > 0)
                    {
                        store = storeRepository.FindById(model.Id);
                        storeRepository.Update(store);
                    }
                    else
                    {
                        storeRepository.Insert(store);
                    }
                }
            }
            return View(model);
        }
    }
}
