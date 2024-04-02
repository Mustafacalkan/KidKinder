﻿using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminLayoutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
	
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
		public PartialViewResult PartialPreLoader()
		{
			return PartialView();
		}
		public PartialViewResult PartialNavbar()
		{
			return PartialView();
		}
		public PartialViewResult PartialNotification()
		{
			var values =context.Notifications.ToList();
			return PartialView(values);
		}
		public PartialViewResult PartialNavbarProfileHeader()
		{
            var currentUser = context.Admins.Where(x => x.Username == User.Identity.Name).FirstOrDefault();
            return PartialView(currentUser);
		}
		public PartialViewResult PartialSidebar()
		{
			var currentUser = context.Admins.Where(x => x.Username == User.Identity.Name).FirstOrDefault();
			return PartialView(currentUser);
		}
		public PartialViewResult PartialScripts()
		{
			return PartialView();
		}
		public PartialViewResult PartialHeader()
		{
			return PartialView();
		}
	}
}