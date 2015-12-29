using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace Gala_MVC_Project.Areas.Admin.Models
{
    public class FirmModel
    {
        public Firm Firm { get; set; }
        public List<Firm> Firms { get; set; }




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

    }
}
