using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminCommunicationController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Communications.FirstOrDefault();
            return View(values);
        }

        public ActionResult UpdateCommunication(int id)
        {
            var value = context.Communications.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCommunication(Communication communication)
        {
            var value = context.Communications.Find(communication.CommunicationId);
            value.Description = communication.Description;
            value.Address = communication.Address;
            value.Phone = communication.Phone;
            value.Email = communication.Email;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}