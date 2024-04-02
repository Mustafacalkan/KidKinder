using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminBookASeatController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.BookASeats.ToList();
            return View(values);
        }
        public ActionResult CreateBookASeat()
        {
            ViewBag.values = new SelectList(context.ClassRooms.ToList(), "ClassroomId", "Title");
            return View();
        }
        [HttpPost]
        public ActionResult CreateBookASeat(BookASeat model)
        {
            context.BookASeats.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveBookASeat(int id)
        {
            var value = context.BookASeats.Find(id);
            context.BookASeats.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateBookASeat(int id)
        {
            var value = context.BookASeats.Find(id);
            ViewBag.values = new SelectList(context.ClassRooms.ToList(), "ClassroomId", "Title");
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBookASeat(BookASeat model)
        {
            var value = context.BookASeats.Find(model.BookASeatId);
            value.ClassRoomId = model.ClassRoomId;
            value.Email = model.Email;
            value.Name = model.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}