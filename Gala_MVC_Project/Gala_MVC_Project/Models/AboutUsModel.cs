using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace Gala_MVC_Project.Models
{
    public class AboutUsModel
    {
        public  Aboutus aboutus { get; set; }
        public List<Team> Executives { get; set; }




        public AboutUsModel()
        {
            aboutus = ManageAboutus.GetAllAboutus().FirstOrDefault();
            Executives = ManageTeam.GetAllTeam().Where(c => c.Type == "Executive").ToList();
        }
        public bool update(AboutUsModel model)
        {
            return ManageAboutus.UpdateAboutus(model.aboutus);
        }

        public bool Insert(AboutUsModel model)
        {
            return ManageAboutus.AddAboutus(model.aboutus);
        }
        public bool Delete(int id)
        {
            return ManageAboutus.DeleteAboutus(ManageAboutus.GetById(id));
        }

    }
}