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







        public EventsModel()
        {
            Events = null;
            Eventss = ManageEvents.GetAllEvents().OrderBy(c=>c.Type).ToList();         
        }

        public void LoadEventPage()
        {
            Eventss = ManageEvents.GetAllEvents().Where(c=>c.Type=="Gala Events"|| c.Type=="Other Events").OrderBy(c => c.Type).ToList(); 
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