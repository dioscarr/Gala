using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Areas.Admin.Models;
using DAL.Models;
using BLL;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class AdminMemberController : Controller
    {
        // GET: Admin/Member
        public ActionResult MemberList()
        {
            ViewBag.Firms = ManageFirm.GetAllFirm().Select(c => new SelectListItem { Text = c.FirmName, Value = c.Id.ToString() }).ToList();

            return View();
        }




    }
}