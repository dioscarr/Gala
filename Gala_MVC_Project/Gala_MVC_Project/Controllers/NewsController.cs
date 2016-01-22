using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Models;

namespace Gala_MVC_Project.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult NewList()
        {
            EventsModel EM = new EventsModel();
            EM.Loadnews();
            EM.LoadPress();
            return View(EM);
        }
        public ActionResult NewsArchive()
        {
            return View();
        }

        public ActionResult NewsArticle(int id)
        {
            EventsModel EM = new EventsModel();
            EM.LoadnewsBy(id);
            return View(EM);
        }
    }
}