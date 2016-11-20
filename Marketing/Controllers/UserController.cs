using Marketing.Business.Models;
using Marketing.DataAccess;
using Marketing.DataAccess.Interface;
using Marketing.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace Marketing.Controllers
{
    public class UserController : Controller
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
                    var user = userRepository.Register(model.UserName, model.Password, model.IsAdmin);
                    if (user.Id > 0)
                    {
                        FormsAuthentication.SetAuthCookie(user.Name, true);
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
                    if (userRepository.IsValid(model.UserName, model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
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
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
