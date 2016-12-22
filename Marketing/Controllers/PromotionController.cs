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
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Marketing.Controllers
{
    public class PromotionController : BaseController
    {
        //private IPromotionRepository promotionRepository;
        public IModelManagementService _mapperService { get; set; }
        public IPromotionRepository promotionRepository { get; set; }
        public IImageRepository imageRepository { get; set; }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var model = new Marketing.Business.Models.Promotion();
            if (Id > 0)
            {
                _mapperService = new ModelManagementService();
                using (promotionRepository = new PromotionRepository())
                {
                    model = _mapperService.MapPromotionToModel(promotionRepository.FindById(Id));
                    //model = _mapperService.MapStoreToModel(storeRepository.FindById(Id));
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Marketing.Business.Models.Promotion model)
        {
            if (ModelState.IsValid)
            {
                using (promotionRepository = new PromotionRepository())
                using (imageRepository = new ImageRepository())
                {

                    var image = new Image()
                    {
                        Name = model.Name,
                        Created = DateTimeHelper.Now(),
                        CreatedBy = Session["UName"].ToString(),
                        IsActive = true,
                        Modified = DateTimeHelper.Now(),
                        ModifiedBy = Session["UName"].ToString()
                    };
                    image = imageRepository.Insert(image);

                    var promotion = new Data.Promotion();
                    promotion.Name = model.Name;
                    promotion.IsActive = model.IsActive;
                    promotion.Created = DateTimeHelper.Now();
                    promotion.CreatedBy = Session["UName"].ToString();
                    promotion.Modified = DateTimeHelper.Now();
                    promotion.ModifiedBy = Session["UName"].ToString(); ;
                    if (model.Id > 0)
                    {
                        promotion = promotionRepository.FindById(model.Id);
                        promotionRepository.Update(promotion);
                    }
                    else
                    {
                        promotionRepository.Insert(promotion);
                    }
                }
            }
            return View(model);
        }
    }
}
