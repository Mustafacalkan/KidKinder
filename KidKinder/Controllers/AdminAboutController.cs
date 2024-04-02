using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminAboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.Abouts.FirstOrDefault();
            return View(value);
        }
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Find(about.AboutId);
            value.AboutBigImageUrl = about.AboutBigImageUrl;
            value.Description = about.Description;
            value.Header = about.Header;
            value.Title = about.Title;
            value.SmallImageUrl = about.SmallImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}