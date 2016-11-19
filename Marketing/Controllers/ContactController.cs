using Marketing.Business.Interface;
using Marketing.Business.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Marketing.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactManagementService _managementService;

        public ContactController(IContactManagementService managementService)
        {
            _managementService = managementService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                //_managementService.CreateContact(contact);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
             //contact = _managementService.GetContact(id);
            //CreateDropDown(contact.ContactTypeId);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
               // _managementService.UpdateContact(contact);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Contact contact)
        {
           // _managementService.DeleteContact(contact);
            return RedirectToAction("Index");
        }
    }
}
