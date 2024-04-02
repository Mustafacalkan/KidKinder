using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
namespace KidKinder.Controllers
{
    public class AboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutListPartial()
        {
            var values = context.AboutLists.ToList();
            return PartialView(values);
        }
    }
}