using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Models;
namespace Gala_MVC_Project.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult EventList()
        {
            EventsModel EM = new EventsModel();
            EM.LoadEventPage();
            return View(EM);
        }
        public ActionResult EventArchive()
        {
            return View();
        }

        public ActionResult Article(int id)
        {
            EventsModel EM = new EventsModel();
            EM.loadEvents(id);
            return View(EM);
        }
    }
}