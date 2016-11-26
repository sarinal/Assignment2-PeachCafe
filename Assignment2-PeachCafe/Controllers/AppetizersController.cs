﻿using System;
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
    public class AppetizersController : Controller
    {
        private PeachCafeContext db = new PeachCafeContext();

        // GET: Appetizers
        public ActionResult Index()
        {
            return View(db.Appetizers.ToList());
        }

        // GET: Appetizers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        // GET: Appetizers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appetizers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AppetizerId,Name,Description,Price")] Appetizer appetizer)
        {
            if (ModelState.IsValid)
            {
                db.Appetizers.Add(appetizer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appetizer);
        }

        // GET: Appetizers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        // POST: Appetizers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AppetizerId,Name,Description,Price")] Appetizer appetizer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appetizer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appetizer);
        }

        // GET: Appetizers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        // POST: Appetizers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appetizer appetizer = db.Appetizers.Find(id);
            db.Appetizers.Remove(appetizer);
            db.SaveChanges();
            return RedirectToAction("Index");
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
