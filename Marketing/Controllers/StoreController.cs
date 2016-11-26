using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
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
    public class StoreController : Controller
    {
        private IStoreManagementRepository storeManagementRepository;
        public IModelManagementService _mapperService { get; set; }
        //
        // GET: /Store/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int? id)
        {

            if (id.HasValue)
            {
                Store model = new Store();
                var _modelmanagementservice = new ModelManagementService();
                var Stores = new List<Store>();
                using (var repos = new StoreManagementRepository())
                {
                    var d = repos.GetAllStore().Where(a => a.Id == id);
                    // Stores = _modelmanagementservice.MapStoreToModel(repos.GetAllStore().Where(a=> a.Id==Store)).ToList();
                }
                return View(Stores);

                // var f = repos.GetAllStore().Where(a => a.Id == id);


                // return View(f.ToList());
            }


            return null;


        }

        //
        // GET: /Store/Create

        public ActionResult Save()
        {
            return View();
        }

        //
        // POST: /Store/Create

        [HttpPost]
        public ActionResult Save(Store model)
        {
            if (ModelState.IsValid)
            {
                using (storeManagementRepository = new StoreManagementRepository())
                {
                    var store = new Data.Store();
                    store.Name = model.Name;
                    store.WebSiteId = 2;
                    store.IsActive = model.IsActive;
                    if (model.Id > 0)
                    {

                        store = storeManagementRepository.FindById(model.Id);
                        storeManagementRepository.Update(store);
                    }
                    else
                    {
                        storeManagementRepository.Insert(store);
                    }
                }
            }
            return View(model);
        }

        //
        // GET: /Store/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Store/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Store/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Store/Delete/5

        [HttpPost]
        public ActionResult Delete(Store model)
        {
            if (ModelState.IsValid)
            {
                using (storeManagementRepository = new StoreManagementRepository())
                {
                    var store = new Data.Store();
                    store.Name = model.Name;
                    store.WebSiteId = 2;
                    store.IsActive = model.IsActive;
                    if (model.Id > 0)
                    {

                        store = storeManagementRepository.FindById(model.Id);
                        storeManagementRepository.Delete(store);
                    }
                    else
                    {
                        
                    }
                }
            }
            return View(model);
        }

     


    }
}
