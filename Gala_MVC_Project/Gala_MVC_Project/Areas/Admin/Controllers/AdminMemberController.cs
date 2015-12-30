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
           
          
            
            return View(new MemberModel());
        }
        [HttpGet]
        public ActionResult AddNewMember()
        {
            CountryModel CM = new CountryModel();
            ViewBag.Countries = CM.Countries.Select(c => new SelectListItem { Text = c.CountryName, Value = c.CountryName }).ToList();//get list of country
            ViewBag.Firms = ManageFirm.GetAllFirm().Select(c => new SelectListItem { Text = c.FirmName, Value = c.Id.ToString() }).ToList();// get list of firms 
            List<SelectListItem> type = new List<SelectListItem>();
            type.Add(new SelectListItem { Text = "Member", Value = "Member" });
            type.Add(new SelectListItem { Text = "Executive", Value = "Executive" });
            ViewBag.type = type;//list of type 
            return View(new MemberModel());
        }
        /// <summary>
        /// Add new Member
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddNewMember(MemberModel model)
        {
            try
            {


                //insert member 
                model.Insert(model);
                model.InsertRelations(model.Member.Id, model.FID, model.CID);// insert relationship country id, member id, firm id 
                return View();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }




    }
}