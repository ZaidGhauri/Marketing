﻿using Marketing.Business.Interface;
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
    public class CouponController : BaseController
    {
        public IModelManagementService _mapperService { get; set; }
        public ICouponRepository couponRepository { get; set; }
        public IImageRepository imageRepository { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = new Marketing.Business.Models.Coupon();
            _mapperService = new ModelManagementService();
            using (couponRepository = new CouponRepository())
            {
                if (Id > 0)
                {
                    model = _mapperService.MapCouponToModel(couponRepository.FindById(Id));
                }
            }
            
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Marketing.Business.Models.Coupon model)
        {
            if (ModelState.IsValid)
            {
                using (couponRepository = new CouponRepository())
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

                    var coupon = new Data.Coupon();
                    coupon.Name = model.Name;
                    coupon.Published = model.Published;
                    coupon.ShowOnHomePage = model.ShowOnHomePage;
                    coupon.IsFeatured = model.IsFeatured;
                    coupon.IncludeInTopMenu = model.IncludeInTopMenu;
                    coupon.FullDescription = model.FullDescription;
                    coupon.Deleted = model.Deleted;
                    coupon.IsActive = model.IsActive;
                    coupon.Created = DateTimeHelper.Now();
                    coupon.CreatedBy = Session["UName"].ToString();
                    coupon.Modified = DateTimeHelper.Now();
                    coupon.ModifiedBy = Session["UName"].ToString();
                    coupon.ImageId = image.Id;
                    if (model.Id > 0)
                    {
                        coupon = couponRepository.FindById(model.Id);
                        couponRepository.Update(coupon);
                    }
                    else
                    {
                        couponRepository.Insert(coupon);
                    }
                }
            }
            return View(model);
        }
    }
}