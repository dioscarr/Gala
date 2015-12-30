﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Areas.Admin.Models;
using DAL.Models;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class CountryFirmController : Controller
    {
        // GET: Admin/CountryFirm
        public ActionResult Index()
        {
            CountryModel CM = new CountryModel();
            ViewBag.Countries = CM.Countries.Select(c => new SelectListItem { Text = c.CountryName, Value = c.CountryName }).ToList();
        
          
            return View(new FirmModel());
        }
        [HttpPost]
        public ActionResult Index(FirmModel model)
        {
            model.Insert(model);
            return RedirectToAction("Firms");
        }

       
        [HttpGet]
        public ActionResult Insert()
        {
            return View(new Country());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(Country model)
        {

            CountryModel CM = new CountryModel();

            CM.Insert(model);
            return RedirectToAction("Firms");
        }

        public ActionResult Firms()
        {
            
            return View(new FirmModel());
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            FirmModel Fm = new FirmModel();
           Fm.Delete(id);
            return RedirectToAction("Firms");
        }
    }
}