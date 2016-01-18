using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Areas.Admin.Models;
using BLL;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class EventsController : Controller
    {
        // GET: Admin/Events
        public ActionResult Index()
        {
            EventsModel EM = new EventsModel();

            return View(EM);
        }
        public ActionResult Delete(int id)
        {
            EventsModel EM = new EventsModel();
            EM.Delete(id);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            List<SelectListItem> type = new List<SelectListItem>();
            type.Add(new SelectListItem { Text = "News", Value = "News" });
            type.Add(new SelectListItem { Text = "Gala Events", Value = "Gala Events" });
            type.Add(new SelectListItem { Text = "Press", Value = "Press" });
            type.Add(new SelectListItem { Text = "Other Events", Value = "Other Events" });

            CountryModel CM = new CountryModel();
            ViewBag.Members = ManageTeam.GetAllTeam().Select(c => new SelectListItem { Text = c.FName + " " + c.LName, Value = c.Id.ToString() }).ToList();
            ViewBag.type = type;//list of type 
            ViewBag.Firms = ManageFirm.GetAllFirm().GroupBy(x => x.FirmName).Select(c => new SelectListItem { Text = c.FirstOrDefault().FirmName, Value = c.FirstOrDefault().Id.ToString() }).ToList();// get list of firms
        
            EventsModel EM = new EventsModel();
            EM.loadEvents(id);
            return View(EM);
        }
        [HttpPost]
       [ValidateInput(false)]
        public ActionResult Update(EventsModel model)
        {
            model.update(model);
            return RedirectToAction("index");
        }
        public ActionResult Insert()
        {
            List<SelectListItem> type = new List<SelectListItem>();
            type.Add(new SelectListItem { Text = "News", Value = "News" });
            type.Add(new SelectListItem { Text = "Gala Events", Value = "Gala Events" });
            type.Add(new SelectListItem { Text = "Press", Value = "Press" });
            type.Add(new SelectListItem { Text = "Other Events", Value = "Other Events" });
           
            CountryModel CM = new CountryModel();
            ViewBag.Members = ManageTeam.GetAllTeam().Select(c => new SelectListItem { Text = c.FName + " " + c.LName, Value = c.Id.ToString() }).ToList();
            ViewBag.type = type;//list of type 
            ViewBag.Firms = ManageFirm.GetAllFirm().GroupBy(x => x.FirmName).Select(c => new SelectListItem { Text = c.FirstOrDefault().FirmName, Value = c.FirstOrDefault().Id.ToString() }).ToList();// get list of firms
            return View();

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Insert(EventsModel model)
        {
            model.Insert(model);
            return RedirectToAction("index");
        }
        public ActionResult Details(int id)
        {
            EventsModel EM = new EventsModel();
            EM.loadEvents(id);

            return View(EM);
        }

    }
}