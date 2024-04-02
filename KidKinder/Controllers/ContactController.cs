using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
using KidKinder.Models;

namespace KidKinder.Controllers
{
	//[AllowAnonymous]
	public class ContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ContactForm()
        {
            return PartialView();
        }
        public PartialViewResult ContactInfo()
        {
            var value = db.Communications.FirstOrDefault();
            return PartialView(value);
        }
        [HttpPost]
        public ActionResult SendMessage(SendMessageViewModel contact)
        {
            if (ModelState.IsValid)
            {
                var value = new Contact()
                {
                    Email = contact.Email,
                    IsRead = false,
                    Message = contact.Message,
                    NameSurname = contact.NameSurname,
                    SendDate = DateTime.Now,
                    Subject = contact.Subject
                };
                db.Contacts.Add(value);
                db.SaveChanges();
                return RedirectToAction("Index", "Contact");
            }
            else
            {

                return RedirectToAction("Index", "Contact");
            }
        }
    }
}

