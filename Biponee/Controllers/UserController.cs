﻿using Biponee.BLL;
using Biponee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biponee.Controllers
{
    public class UserController : Controller
    {
        ProductManager productManager = new ProductManager();
        SectionManager sectionManager = new SectionManager();
        // GET: User
        public ActionResult Index()
        {
            List<ProductC> productList = productManager.getAllProduct();
            List<SectionC> sections = sectionManager.getAllSections();
            ViewBag.sections = sections;
            return View(productList);
        }

        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult CustmerAccount()
        {
            return View();
        }

        public ActionResult ProductPage()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }

        public JsonResult getAllProduct()
        {
            List<ProductC> list = productManager.getAllProduct();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


    }
}