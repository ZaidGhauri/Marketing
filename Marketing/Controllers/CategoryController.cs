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
    public class CategoryController : Controller
    {
        private ICategoryManagementRepository categoryManagementRepository;
        public IModelManagementService _mapperService { get; set; }
        //
        // GET: /Category/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int? id)
        {

            if (id.HasValue)
            {
                Category model = new Category();
                var _modelmanagementservice = new ModelManagementService();
                var Categories = new List<Category>();
                using (var repos = new CategoryManagementRepository())
                {
                    var d = repos.GetAllCategory().Where(a => a.Id == id);
                
                }
                return View(Categories);

            }


            return null;


        }
        //
        // GET: /Category/Create

        public ActionResult Save()
        {
            return View();
        }

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Save(Category model)
        {
            if (ModelState.IsValid)
            {
                using (categoryManagementRepository = new CategoryManagementRepository())
                {
                    var category = new Data.Category();
                    category.Name = model.Name;
                    category.WebSiteId = 2;
                    category.IsActive = model.IsActive;
                    if (model.Id > 0)
                    {

                        category = categoryManagementRepository.FindById(model.Id);
                        categoryManagementRepository.Update(category);
                    }
                    else
                    {
                        categoryManagementRepository.Insert(category);
                    }
                }
            }
            return View(model);
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Category/Edit/5

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
        // GET: /Category/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Category/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
