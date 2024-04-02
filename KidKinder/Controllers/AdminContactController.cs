using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View(context.Contacts.ToList());
        }
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveContact(int id)
        {
            context.Contacts.Remove(context.Contacts.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ContactDetails(int id)
        {
            var value = context.Contacts.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return View(value);
        }
        
    }
}
