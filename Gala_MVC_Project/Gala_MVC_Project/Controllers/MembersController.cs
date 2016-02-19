using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Models;

namespace Gala_MVC_Project.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Firm(int id, string Country)
        {
            ViewBag.country = Country;
            FirmModel FM = new FirmModel();

            FM.loadFirm(id);
            return View(FM);
        }
        public ActionResult MemberList(int? CountryID, int? FirmID, int? memberID)
        {
            MemberModel MM = new MemberModel();           
          
            if (CountryID != null ||FirmID !=null || memberID!=null)
            { MM.LoadMemberList(CountryID,FirmID,memberID);}            
            else {MM.LoadMemberList();}

            return View(MM);
        }

        public ActionResult Member(int id)
        {
            MemberModel MM = new MemberModel();
            MM.loadMember(id);
            return View(MM);
        }
    }
}