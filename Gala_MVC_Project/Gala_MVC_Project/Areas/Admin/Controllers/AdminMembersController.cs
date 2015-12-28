using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class AdminMembersController : Controller
    {
        // GET: Admin/AdminMembers
        public ActionResult Index()
        {
            return View();
        }
    }
}