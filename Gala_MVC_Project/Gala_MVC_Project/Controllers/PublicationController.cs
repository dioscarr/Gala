using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Controllers
{
    public class PublicationController : Controller
    {
        // GET: Publication
        public ActionResult Publication()
        {
            return View();
        }
        public ActionResult GazetteArchive()
        {
            return View();
        }
        public ActionResult GazetteArticle()
        {
            return View();
        }
    }
}