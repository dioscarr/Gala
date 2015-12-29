using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult NewList()
        {
            return View();
        }
        public ActionResult NewArchive()
        {
            return View();
        }
    }
}