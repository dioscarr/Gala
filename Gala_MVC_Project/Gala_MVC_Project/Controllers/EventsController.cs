﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gala_MVC_Project.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult EventList()
        {
            return View();
        }
        public ActionResult EventArchive()
        {
            return View();
        }
    }
}