using Marketing.Business.Interface;
using Marketing.Business.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;


namespace Marketing.Controllers
{
    public class ContactTypeController : Controller
    {
        private readonly IContactManagementService _managementService;

        public ContactTypeController(IContactManagementService managementService)
        {
            _managementService = managementService;
        }

        //
        // GET: /ContactType/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new ContactType());
        }

        [HttpPost]
        public ActionResult Create(ContactType contactType)
        {
            if (ModelState.IsValid)
            {
               // _managementService.CreateContactType(contactType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            //return View(_managementService.GetContactType(id));
            return View();
        }

        [HttpPost]
        public ActionResult Edit(ContactType contactType)
        {
            if (ModelState.IsValid)
            {
               // _managementService.UpdateContactType(contactType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            //return View(_managementService.GetContactType(id));
            return View();
        }

        [HttpPost]
        public ActionResult Delete(ContactType contactType)
        {
           // _managementService.DeleteContactType(contactType);
            return RedirectToAction("Index");
        }
    }
}
