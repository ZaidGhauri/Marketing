using Marketing.DataAccess;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using Marketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketing.Controllers
{
    public class UserController : BaseController
    {
        private IUserManagementRepository userRepository;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                using (userRepository = new UserManagementRepository())
                {
                   
                    var user = userRepository.Register(model.UserName, model.Password, WebSite.Id, model.IsAdmin);
                    if (user.Id > 0)
                    {
                        Session["UName"] = model.UserName;
                    }
                    else
                    {
                        ModelState.AddModelError("", "Register data is incorrect!");
                    }
                }
            }
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (userRepository = new UserManagementRepository())
                {
                    if (userRepository.IsValid(model.UserName, model.Password, WebSite.Id))
                    {
                        Session["UName"] = model.UserName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Login data is incorrect!");
                    }
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
