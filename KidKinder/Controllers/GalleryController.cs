﻿using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KidKinder.Controllers
{
	//[AllowAnonymous]
	public class GalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GalleryHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult PartialGallery()
        {

			var values = context.Gallery.Where(x => x.Status == true).Take(6).ToList();
			return PartialView(values);
		}
    }
}