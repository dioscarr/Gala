using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Models;

namespace Gala_MVC_Project.Controllers
{
    public class PublicationController : Controller
    {
        // GET: Publication
        public ActionResult Publication()
        {
            PublicationModel PM = new PublicationModel();
            return View(PM);
        }
        public ActionResult GazetteArchive()
        {
            return View();
        }
        public ActionResult GazetteArticle(int id)
        {
            PublicationModel PM = new PublicationModel();
            PM.GazetteArticle = PM.GazetteArticles.Where(c => c.Id == id).FirstOrDefault();
            return View(PM);
           
        }
    }
}