using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;
using Gala_MVC_Project.Areas.Admin.Models;

namespace Gala_MVC_Project.Areas.Admin.Models
{
    public class FirmModel:Basemodel
    {
        public Firm Firm { get; set; }
        public List<Firm> Firms { get; set; }
        public int MID { get; set; }
        public int FID { get; set; }
        public string CID { get; set; }




        public FirmModel()
        {
            Firm = null;
            Firms = ManageFirm.GetAllFirm().ToList();
        }
        public bool update(FirmModel model)
        {
            return ManageFirm.UpdateFirm(model.Firm);
        }

        public bool Insert(FirmModel model)
        {
            return ManageFirm.AddFirm(model.Firm);
        }
        public bool Delete(int id)
        {
            return ManageFirm.DeleteFirm(ManageFirm.GetById(id));
        }


        internal void loadFirmById(int id)
        {
            Firm = ManageFirm.GetById(id);
        }
    }
}
