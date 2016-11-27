using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2_PeachCafe.Models;

namespace Assignment2_PeachCafe.Controllers
{
    public class MenuCoursesController : Controller
    {
        private PeachCafeContext db = new PeachCafeContext();

        // GET: MenuCourses
        public ActionResult Index()
        {
            return View(db.MenuCourses.ToList());
        }

        // GET: MenuCourses/Details/5
        public ActionResult Details(int? id=1)
        {
     
            MenuCourse menuCourse = db.MenuCourses.Find(id);
            if (menuCourse == null)
            {
                return HttpNotFound();
            }
            return View(menuCourse);
        }


        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
