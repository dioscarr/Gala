﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;
using Gala_MVC_Project.Models;


namespace Gala_MVC_Project.Models
{
    
    public class EventsModel:Basemodel
    {
        GalaDBEntities db = new GalaDBEntities();

         public Events Events { get; set; }
        public List<Events> Eventss { get; set; }          
        public HttpPostedFileBase ImageUpload { get; set; }
        public bool isNewPicture { get; set; }
        public List<Events> news { get; set; }
        public Events newsSingle { get; set; }
        public List<Events> Press { get; set; }
        public Events PressSingle { get; set; }
        public List<Events> TheEvents { get; set; }
        public List<Events> OtherEvents { get; set; }







        public EventsModel()
        {
            PressSingle = null;
            Press = null;
            news = null;
            Events = null;
            Eventss = ManageEvents.GetAllEvents().OrderBy(c=>c.Type).ToList();         
        }

        public void LoadEventPage()
        {
            Eventss = ManageEvents.GetAllEvents().Where(c=>c.Type=="Gala Events"|| c.Type=="Other Events").OrderBy(c => c.Type).ToList(); 
        }

        public void Loadnews()
        {
            news = ManageEvents.GetAllEvents().Where(c => c.Type == "News").OrderBy(c => c.Type).ToList();
        }
        public void LoadnewsBy(int id)
        {
            newsSingle = db.Events.Where(c=>c.id==id).FirstOrDefault();
        }
        public void LoadPress()
        {
            Press = ManageEvents.GetAllEvents().Where(c => c.Type == "Press").OrderBy(c => c.Type).ToList();
        }

        public void LoadPressBY(int id)
        {
            PressSingle = db.Events.Where(c => c.id == id).FirstOrDefault();
        }

        public void loadEvents(int id) {
            Events = db.Events.Where(c => c.id == id).FirstOrDefault();
        }

        public bool update(EventsModel model)
        {
            return ManageEvents.UpdateEvents(model.Events);
        }

        public bool Insert(EventsModel model)
        {
            return ManageEvents.AddEvents(model.Events);
        }
       
        public bool Delete(int id)
        {
            return ManageEvents.DeleteEvents(ManageEvents.GetById(id));
        }
        
    }

   
}