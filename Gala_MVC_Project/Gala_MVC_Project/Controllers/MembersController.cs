using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Firm()
        {
            return View();
        }
        public ActionResult MemberList()
        {
            return View();
        }

        public ActionResult Member()
        {
            return View();
        }
    }
}