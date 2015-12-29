using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;
using Gala_MVC_Project.Areas.Admin.Models;

namespace Gala_MVC_Project.Areas.Admin.Models
{
    public class MemberModel:Basemodel
    {
         public Team team { get; set; }
        public List<Team> teams { get; set; }




        public MemberModel()
        {
            team = null;
            teams = ManageTeam.GetAllTeam().ToList();
        }
        public bool update(MemberModel model)
        {
            return ManageTeam.UpdateTeam(model.team);
        }

        public bool Insert(MemberModel model)
        {
            return ManageTeam.AddTeam(model.team);
        }
        public bool Delete(int id)
        {
            return ManageTeam.DeleteTeam(ManageTeam.GetById(id));
        }
        
    }
}