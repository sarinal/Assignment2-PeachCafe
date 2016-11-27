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
    public class CafeController : Controller
    {
        private PeachCafeContext db = new PeachCafeContext();

        // GET: Cafe
        public ActionResult Index()
        {
        //    List<MenuCourse> menucourses = new List<MenuCourse>
        //    {
        //        new MenuCourse("Appetizer"),
        //    new MenuCourse("Main"),
        //    new MenuCourse("Beverage"),
        //    new MenuCourse("Sweet")
        //};
            return View(db.MenuCourses.ToList());
        }

        //GET: Cafe/Browse?menucourse=appetizer
        public ActionResult Browse(string menucourse)
        {
            if(menucourse == null)
            {
                menucourse = "Appetizer";
            }

            MenuCourse menuCourseModel = db.MenuCourses.Include("FoodItems").SingleOrDefault(g => g.Name == menucourse);
            return View(menuCourseModel);
        }

        // GET: Cafe/Details/5
        public ActionResult Details(int? id = 1)
        {
            FoodItem fooditem = new FoodItem("FoodItem" + id);
            return View(fooditem);
        }


    }
}
