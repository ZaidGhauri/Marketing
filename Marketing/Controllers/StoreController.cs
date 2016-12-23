using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
using Marketing.Common;
using Marketing.Data;
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
        public IImageRepository imageRepository { get; set; }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var model = new Marketing.Business.Models.Store();
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
        public ActionResult Edit(Marketing.Business.Models.Store model)
        {
            if (ModelState.IsValid)
            {
                using (storeRepository = new StoreRepository())
                using (imageRepository = new ImageRepository())
                {
                    var image = new Image()
                    {
                        Name = model.ImagePath,
                        Created = DateTimeHelper.Now(),
                        CreatedBy = Session["UName"].ToString(),
                        IsActive = true,
                        Modified = DateTimeHelper.Now(),
                        ModifiedBy = Session["UName"].ToString()
                    };
                    image = imageRepository.Insert(image);
                    var store = new Data.Store();
                    store.Name = model.Name;
                    store.Published = model.Published;
                    store.ShowOnHomePage = model.ShowOnHomePage;
                    store.CompanyId = 0;
                    store.CompanyName = model.CompanyName;
                    store.CompanyPhoneNo = model.CompanyPhoneNo;
                    store.IsNew = model.IsNew;
                    store.IsPopular = model.IsPopular;
                    store.IsFeatured = model.IsFeatured;
                    store.IncludeInTopMenu = model.IncludeInTopMenu;
                    store.Deleted = model.Deleted;
                    store.WebSiteId = WebSite.Id;
                    store.IsActive = model.IsActive;
                    store.Created = DateTimeHelper.Now();
                    store.CreatedBy = Session["UName"].ToString();
                    store.Modified = DateTimeHelper.Now();
                    store.ModifiedBy = Session["UName"].ToString();
                    store.ImageId = image.Id;
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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Store data is incorrect!");
                return View(model);
            }
        }
    }
}
