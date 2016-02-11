using Gala_MVC_Project.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gala_MVC_Project.Areas.Admin.Models;
using System.Net.Mail;
using Microsoft.AspNet.Identity;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: Admin/UserManagement


        ApplicationDbContext context;

        public UserManagementController()
        {
            context = new ApplicationDbContext();
        }

        /// <summary>
        /// Get All Roles
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {


            Usermanagement UM = new Usermanagement();
         
            
            return View(UM);
        }
        [HttpPost]
        public ActionResult Index(Usermanagement model)
        {
            
                string password = PasswordGenerator.GeneratePassword("8").ToString();
                var UserID = RegisterUsers.RegisterNewsUser(model.EmailAddress, password);
                var result = RegisterUsers.UserToRole(model.RoleName, UserID);
                Usermanagement UM = new Usermanagement();
            return View(UM);
        }

        [HttpGet]
        public ActionResult DeleteRole(string RoleName)
        {
            RegisterUsers.DeleteRole(RoleName);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Create  a New role
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        /// <summary>
        /// Create a New Role
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public JsonResult getRoles(string Email) 
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            ApplicationUser AppUser = new ApplicationUser();
            List<string> pre_roles = new List<string>();
            AppUser = userManager.FindByEmail(Email);
            if (AppUser != null)
            {
                pre_roles = userManager.GetRoles(AppUser.Id).ToList();
            }
            else {
                string password = PasswordGenerator.GeneratePassword("8").ToString();
                var UserID = RegisterUsers.RegisterNewsUser(Email, password);
                pre_roles = userManager.GetRoles(UserID).ToList();
            }
           
           
            var roles = Json(pre_roles);
           
            return new JsonResult { Data = roles, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}