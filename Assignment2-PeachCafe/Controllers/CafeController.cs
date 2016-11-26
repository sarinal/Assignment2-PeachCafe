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
            return View(db.MenuCourses.ToList());
        }

        // GET: Cafe/Details/5
        public ActionResult Details(int? id= 1)
        {
            return View();
        }

        
    }
}
