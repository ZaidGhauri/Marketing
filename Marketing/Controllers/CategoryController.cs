using Marketing.Business.Interface;
using Marketing.Business.Models;
using Marketing.Business.Services;
using Marketing.Common;
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
    public class CategoryController : BaseController
    {
        private ICategoryRepository categoryRepository;
        public IModelManagementService _mapperService { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id, string type)
        {
            var model = new Category();

            _mapperService = new ModelManagementService();
            using (categoryRepository = new CategoryRepository())
            {
                if (type == "SubCategory")
                {
                    var categories = categoryRepository.All().ToList();
                    foreach (var item in categories)
                    {
                        model.Categories.Add(new SelectListItem()
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
                if (Id > 0)
                {
                    model = _mapperService.MapCategoryToModel(categoryRepository.FindById(Id));
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                using (categoryRepository = new CategoryRepository())
                {
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
                    category.ModifiedBy = Session["UName"].ToString(); ;
                    if (model.Id > 0)
                    {
                        category = categoryRepository.FindById(model.Id);
                        categoryRepository.Update(category);
                    }
                    else
                    {
                        categoryRepository.Insert(category);
                    }
                }
            }
            return View(model);
        }
    }
}
