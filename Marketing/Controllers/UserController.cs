using Marketing.Common;
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
        private RegisterModel BindRegisterData(RegisterModel model)
        {
            model.DateOfBirth = DateTimeHelper.Now();
            using (var countryRepo = new CountryRepository())
            {
                var countries = countryRepo.All().ToList();

                foreach (var item in countries)
                {
                    model.Countries.Add(new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
            }
            return model;
        }
        public ActionResult Register()
        {
            RegisterModel model = new RegisterModel();
            model.DateOfBirth = DateTimeHelper.Now();
            using (var countryRepo = new CountryRepository())
            {
                var countries = countryRepo.All().ToList();

                foreach (var item in countries)
                {
                    model.Countries.Add(new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                using (userRepository = new UserManagementRepository())
                {
                    var user = new Marketing.Data.User()
                    {
                        Name = model.UserName,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        IsAdmin = model.IsAdmin,
                        WebSiteId = WebSite.Id,
                        CountryId = model.CountryId,
                        Phone = model.Phone,
                        DateOfBirth = model.DateOfBirth,
                        Address = model.Address,
                        City = model.City,
                        Gender = model.Gender,
                        IsNewsLetter = model.IsNewsLetter,
                        Password = model.Password,
                        PostCode = model.PostCode,
                        State = model.State
                    };
                    userRepository.Insert(user);
                    Session["UName"] = model.UserName;
                    Session["IsAdmin"] = model.IsAdmin;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login data is incorrect!");
                model = BindRegisterData(model);

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
                    var user = userRepository.ValidUser(model.UserName, model.Password, WebSite.Id);
                    if (user != null && user.Id > 0)
                    {
                        Session["UName"] = model.UserName;
                        Session["IsAdmin"] = user.IsAdmin;
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
        public ActionResult LoginError()
        {
            return View();
        }
    }
}
