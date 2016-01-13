using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;
using Gala_MVC_Project.Areas.Admin.Models;


namespace Gala_MVC_Project.Areas.Admin.Models
{
    
    public class EventsModel:Basemodel
    {
        GalaDBEntities db;

         public Events Events { get; set; }
        public List<Events> Eventss { get; set; }
        public int FID { get; set; }
        public int CID { get; set; }
        public List<EventsList> EventsList { get; set; }
        public List<CMFRelation> CMF { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
        public bool isNewPicture { get; set; }







        public EventsModel()
        {
            Events = null;
            Eventss = ManageEvents.GetAllEvents().ToList();
            FID=0;
            CID=0;
        }

        

        public void loadEvents(int id) {
            Events = ManageEvents.GetById(id);
        }

        public bool update(EventsModel model)
        {
            return ManageEvents.UpdateEvents(model.Events);
        }

        public bool Insert(EventsModel model)
        {
            return ManageEvents.AddEvents(model.Events);
        }
        public bool InsertRelations(int MID, int FID, int CID)
        {
            CMFRelation CM = new CMFRelation();
            CM.CID = CID;
            CM.FID = FID;
            CM.MID = MID;
            return ManageCMFRelation.AddCMFRelation(CM);
        }

        public bool DeleteRef(int id)
        {
            return ManageCMFRelation.DeleteCMFRelation(ManageCMFRelation.GetById(id));
        }
        public bool Delete(int id)
        {
            return ManageEvents.DeleteEvents(ManageEvents.GetById(id));
        }
        
    }

    public class EventsList
    {
        public int id { get; set; }
        public int FID { get; set; }
        public int MID { get; set; }
        public string Country { get; set; }
        public string Firm { get; set; }
        public string Name { get; set; }
    }
}