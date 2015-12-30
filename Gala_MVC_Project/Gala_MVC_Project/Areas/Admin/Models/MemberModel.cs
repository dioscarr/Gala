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
         public Team Member { get; set; }
        public List<Team> Members { get; set; }
        public int FID { get; set; }
        public int CID { get; set; }





        public MemberModel()
        {
            Member = null;
            Members = ManageTeam.GetAllTeam().ToList();
            FID=0;
            CID=0;
        }
        public bool update(MemberModel model)
        {
            return ManageTeam.UpdateTeam(model.Member);
        }

        public bool Insert(MemberModel model)
        {
            return ManageTeam.AddTeam(model.Member);
        }
        public bool InsertRelations(int MID, int FID, int CID)
        {
            CMFRelation CM = new CMFRelation();
            CM.CID = CID;
            CM.FID = FID;
            CM.MID = FID;
            return ManageCMFRelation.AddCMFRelation(CM);
        }
        public bool Delete(int id)
        {
            return ManageTeam.DeleteTeam(ManageTeam.GetById(id));
        }
        
    }
}