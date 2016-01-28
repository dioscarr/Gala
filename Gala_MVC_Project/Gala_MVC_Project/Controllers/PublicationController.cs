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
        public ActionResult GazetteArchive(int id)
        {
            PublicationModel PM = new PublicationModel();
            PM.loadGazettebyVolume(id);
            return View(PM);
        }
        public ActionResult GazetteArticle(int id)
        {
            PublicationModel PM = new PublicationModel();
            PM.GazetteArticle = PM.GazetteArticles.Where(c => c.Id == id).FirstOrDefault();
            return View(PM);
           
        }
        [HttpGet]
        [AllowAnonymous]
        public JsonResult GazetteVolumes()
        {

            //List<VolumesModel> model = new List<VolumesModel>();
            //List<Countries> model2 = new List<Countries>();
            //model2.Add( new Countries { cname = "USA", id=1, Content = "This package can also be installed from within Visual Studio from the Visual Studio Online Gallery using the Tools | Extension Manager option. Select the online gallery and search for Visual Studio Spell Checker. Include the quote marks for an exact match and find the one created by EWSoftware. Once found, you can click the Download button to download and install it." });
            //model2.Add(new Countries { cname = "Argentina", id = 2, Content = "version of Visual Studio 2013 and later. The Community Edition is also supported but the older Express editions are not as they do not allow installation of extensions. Consider switching to the newer Community Edition which does support them." });
            //model2.Add(new Countries { cname = "Mexico", id = 3, Content = "hfgjsrghrgnrfgnThis package can, alsogjh,g be irnfh,gj,gngj,gh,nrfhnnstalled from within Visual Studio from the Visual Studio Online Gallery using the Tools | Extension Manager option. Select the online gallery and search for Visual Studio Spell Checker. Include the quote marks for an exact match and find the one created by EWSoftware. Once found, you can click the Download button to download and install it." });
            //model2.Add(new Countries { cname = "Brazil", id = 4, Content = "fghnfghntmtjgm,jtg,m,jg,versionjh,gjh of Visugnj,jgfghnfghnal Studio 2013 andfgndfg later. The Community Edition is also supported but the older Express editions are not as they do not allow installation of extensions. Consider switching to the newer Community Edition which does support them." });
            // model.Add(new VolumesModel
            //{
            //    id = 1,
            //    name = "Volume 10, Issue 2",
            //    countries = model2
            //});
            //List<Countries> model3 = new List<Countries>();
            //model3.Add(new Countries { cname = "Mexico", id = 3, Content = "hfgjsrghrgnrfgnThis package can, alsogjh,g be irnfh,gj,gngj,gh,nrfhnnstalled from within Visual Studio from the Visual Studio Online Gallery using the Tools | Extension Manager option. Select the online gallery and search for Visual Studio Spell Checker. Include the quote marks for an exact match and find the one created by EWSoftware. Once found, you can click the Download button to download and install it." });
            //model3.Add(new Countries { cname = "Brazil", id = 4, Content = "fghnfghntmtjgm,jtg,m,jg,versionjh,gjh of Visugnj,jgfghnfghnal Studio 2013 andfgndfg later. The Community Edition is also supported but the older Express editions are not as they do not allow installation of extensions. Consider switching to the newer Community Edition which does support them." });
            //model3.Add(new Countries { cname = "USA", id = 1, Content = "This package can also be installed from within Visual Studio from the Visual Studio Online Gallery using the Tools | Extension Manager option. Select the online gallery and search for Visual Studio Spell Checker. Include the quote marks for an exact match and find the one created by EWSoftware. Once found, you can click the Download button to download and install it." });
            //model3.Add(new Countries { cname = "Argentina", id = 2, Content = "version of Visual Studio 2013 and later. The Community Edition is also supported but the older Express editions are not as they do not allow installation of extensions. Consider switching to the newer Community Edition which does support them." });
            //model3.Add(new Countries { cname = "Mexico", id = 3, Content = "hfgjsrghrgnrfgnThis package can, alsogjh,g be irnfh,gj,gngj,gh,nrfhnnstalled from within Visual Studio from the Visual Studio Online Gallery using the Tools | Extension Manager option. Select the online gallery and search for Visual Studio Spell Checker. Include the quote marks for an exact match and find the one created by EWSoftware. Once found, you can click the Download button to download and install it." });
            //model3.Add(new Countries { cname = "Brazil", id = 4, Content = "fghnfghntmtjgm,jtg,m,jg,versionjh,gjh of Visugnj,jgfghnfghnal Studio 2013 andfgndfg later. The Community Edition is also supported but the older Express editions are not as they do not allow installation of extensions. Consider switching to the newer Community Edition which does support them." });
            //model.Add(new VolumesModel
            //{
            //    id = 2,
            //    name = "Volume 9, Issue 1",
            //    countries = model3
            //});

            PublicationModel PM = new PublicationModel();


            var mymodel = Json(PM.mymodel);
            return new JsonResult() { Data = mymodel, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}