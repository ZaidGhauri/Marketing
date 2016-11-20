using Marketing.DataAccess;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using Marketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace Marketing.Controllers
{
    public class AboutController : Controller
    {
        private IContactUsManagementRepository contactRepository;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(ContactUsModel model)
        {
            var msg = string.Empty;
            if (ModelState.IsValid)
            {
                using (contactRepository = new ContactUsManagementRepository())
                {
                    var contact = new Marketing.Data.ContactUs();
                    contact.CountryId = model.CountryId;
                    contact.FirstName = model.FirstName;
                    contact.LastName = model.LastName;
                    contact.Phone = model.Phone;
                    contact.Email = model.Email;
                    contact.Comments = model.Comments;
                    contact.WebSiteId = 1;
                    msg = contactRepository.Submit(contact);
                }
            }
            else
            {
                ModelState.AddModelError("", "Contact Us data is incorrect!");
            }
            ViewBag.Message = msg;
            return View(model);
        }
    }
}
