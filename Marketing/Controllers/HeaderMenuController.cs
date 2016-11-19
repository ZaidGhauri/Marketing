using Marketing.DataAccess;
using Marketing.DataAccess.Repositories;
using Marketing.Business.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketing.Controllers
{
    public class HeaderMenuController : Controller
    {
        //
        // GET: /HeaderMenu/

        public ActionResult Index()
        {
            Marketing.Data.HeaderMenu model = new Marketing.Data.HeaderMenu();
            var repos = new ModelManagementRepository();
           // var f =repos.GetAllCategory().ToList();
          
            model.Categories =repos.GetAllCategory().ToList();
            model.Stores = repos.GetAllStore().ToList();
            return View(model);
                   
        }


        //
        // GET: /HeaderMenu/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /HeaderMenu/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HeaderMenu/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HeaderMenu/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HeaderMenu/Edit/5

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
        // GET: /HeaderMenu/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HeaderMenu/Delete/5

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
