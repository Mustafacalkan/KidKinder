using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminGaleriController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View(context.Gallery.ToList());
        }
        public ActionResult CreateImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateImage(Gallery gallery)
        {
            context.Gallery.Add(gallery);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
		public ActionResult ImageChangeStatusTrue(int id)
		{
			var value = context.Gallery.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult ImageChangeStatusFalse(int id)
		{
			var value = context.Gallery.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
        public ActionResult UpdateImage(int id)
        {
            var value = context.Gallery.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateImage(Gallery gallery)
        {
            var value = context.Gallery.Find(gallery.GalleryId);
            value.ImageUrl = gallery.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}