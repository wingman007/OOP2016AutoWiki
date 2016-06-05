using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoWiki.Models;

namespace AutoWiki.Controllers
{
    public class BikesController : Controller
    {
        private BikesDBContent db = new BikesDBContent();

        // GET: Bikes
        public ActionResult Index()
        {
            return View(db.Bike.ToList());
        }

        // GET: Bikes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bikes bikes = db.Bike.Find(id);
            if (bikes == null)
            {
                return HttpNotFound();
            }
            return View(bikes);
        }

        // GET: Bikes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bikes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Model,Year,Category,Engine,Power,Gearbox,Fuel,Fuelcapacity,Topspeed")] Bikes bikes)
        {
            if (ModelState.IsValid)
            {
                db.Bike.Add(bikes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bikes);
        }

        // GET: Bikes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bikes bikes = db.Bike.Find(id);
            if (bikes == null)
            {
                return HttpNotFound();
            }
            return View(bikes);
        }

        // POST: Bikes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Model,Year,Category,Engine,Power,Gearbox,Fuel,Fuelcapacity,Topspeed")] Bikes bikes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bikes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bikes);
        }

        // GET: Bikes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bikes bikes = db.Bike.Find(id);
            if (bikes == null)
            {
                return HttpNotFound();
            }
            return View(bikes);
        }

        // POST: Bikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bikes bikes = db.Bike.Find(id);
            db.Bike.Remove(bikes);
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
