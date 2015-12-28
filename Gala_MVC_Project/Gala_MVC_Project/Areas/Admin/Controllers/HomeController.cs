using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
   


     //public ActionResult UpdateFirm(FirmModel model)
     //   {
     //       if (model.isNewPicture)
     //       {
     //           model.FirmDetail.picture = ImageUloadFirm(model, "~/Images/advisory");
     //       }
          
     //       model.Update(model);
     //       return RedirectToAction("index");
     //   }

     // //upload image
     //   public string ImageUloadFirm(FirmModel model, string url)
     //   {
     //       var validImageTypes = new string[]
     //       {
     //           "image/gif",
     //           "image/jpeg",
     //           "image/jpg",
     //           "image/pjpeg",
     //           "image/png"
     //       };

     //       if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
     //       {
     //           ModelState.AddModelError("ImageUpload", "This field is required");
     //       }
     //       else if (!validImageTypes.Contains(model.ImageUpload.ContentType))
     //       {
     //           ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
     //       }

     //       if (ModelState.IsValid)
     //       {
     //           if (model.ImageUpload != null && model.ImageUpload.ContentLength > 0)
     //           {
     //               var uploadDir = url;
     //               var imagePath = Path.Combine(Server.MapPath(uploadDir), model.ImageUpload.FileName);
     //               var imageUrl = Path.Combine(uploadDir, model.ImageUpload.FileName);
     //               model.ImageUpload.SaveAs(imagePath);
     //               return model.ImageUpload.FileName;
     //           }
     //       } return "noimg.jpg";
     //   }

    }
}