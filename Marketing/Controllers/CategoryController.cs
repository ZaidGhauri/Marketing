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
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Marketing.Controllers
{
    public class CategoryController : BaseController
    {

        public IModelManagementService _mapperService { get; set; }
        public ICategoryRepository categoryRepository { get; set; }
        public IImageRepository imageRepository { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int Id)
        {
            var model = new Marketing.Business.Models.Category();
            _mapperService = new ModelManagementService();
            using (categoryRepository = new CategoryRepository())
            {
                if (Id > 0)
                {
                    model = _mapperService.MapCategoryToModel(categoryRepository.FindById(Id));
                }
            }
            return View(model);
        }
        public ActionResult Edit(int Id, string type)
        {
            var model = new Marketing.Business.Models.Category();
            _mapperService = new ModelManagementService();
            using (categoryRepository = new CategoryRepository())
            {
                if (Id > 0)
                {
                    model = _mapperService.MapCategoryToModel(categoryRepository.FindById(Id));
                }
                if (type == "SubCategory")
                {
                    var categories = categoryRepository.All().Where(a => a.ParentCategoryId == 0).ToList();
                    foreach (var item in categories)
                    {
                        model.SubCategories.Add(new SelectListItem()
                        {
                            Text = item.Name,
                            Value = item.Id.ToString()
                        });
                    }
                }
                else
                {
                    model.ParentCategoryId = 0;
                }
            }
            model.type = type;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Marketing.Business.Models.Category model)
        {
            if (ModelState.IsValid)
            {
                using (categoryRepository = new CategoryRepository())
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

                    var category = new Data.Category();
                    category.Name = model.Name;
                    category.Published = model.Published;
                    category.ShowOnHomePage = model.ShowOnHomePage;
                    category.ParentCategoryId = model.type == "Category" ? 0 : model.ParentCategoryId;
                    category.IsFeatured = model.IsFeatured;
                    category.IncludeInTopMenu = model.IncludeInTopMenu;
                    category.Description = model.Description;
                    category.Deleted = model.Deleted;
                    category.WebSiteId = WebSite.Id;
                    category.IsActive = model.IsActive;
                    category.Created = DateTimeHelper.Now();
                    category.CreatedBy = Session["UName"].ToString();
                    category.Modified = DateTimeHelper.Now();
                    category.ModifiedBy = Session["UName"].ToString();
                    if (model.Id > 0)
                    {
                        category = categoryRepository.FindById(model.Id);
                        var img = imageRepository.FindById(category.ImageId);
                        category.ImageId = image.Id;
                        categoryRepository.Update(category);
                        if (img != null)
                        {
                            img.IsActive = false;
                            img.Modified = DateTimeHelper.Now();
                            img.ModifiedBy = Session["UName"].ToString();
                        }
                    }
                    else
                    {
                        category.ImageId = image.Id;
                        categoryRepository.Insert(category);
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Category data is incorrect!");
                return View(model);
            }
        }
        public ActionResult SaveImage(IEnumerable<HttpPostedFileBase> attachments)
        {
            foreach (var file in attachments)
            {
                var destinationPath = Path.Combine(Server.MapPath("~/Storage/Images"), file.FileName);
                file.SaveAs(destinationPath);
            }
            return Content("");
        }
        public ActionResult Remove(string[] fileNames)
        {
            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var physicalPath = Path.Combine(Server.MapPath("~/Storage/Images"), fullName);
                    if (System.IO.File.Exists(physicalPath))
                    {
                        System.IO.File.Delete(physicalPath);
                    }
                }
            }
            return Content("");
        }

    }
}
