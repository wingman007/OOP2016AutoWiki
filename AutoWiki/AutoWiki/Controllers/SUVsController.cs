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
    public class SUVsController : Controller
    {
        private CarsDBContent db = new CarsDBContent();

        // GET: SUVs
        public ActionResult Index()
        {
            return View(db.SUVS.ToList());
        }

        // GET: SUVs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUV sUV = db.SUVS.Find(id);
            if (sUV == null)
            {
                return HttpNotFound();
            }
            return View(sUV);
        }

        // GET: SUVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SUVs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Brand,Model,Engine,HorsePower,MaxSpeed")] SUV sUV)
        {
            if (ModelState.IsValid)
            {
                db.SUVS.Add(sUV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sUV);
        }

        // GET: SUVs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUV sUV = db.SUVS.Find(id);
            if (sUV == null)
            {
                return HttpNotFound();
            }
            return View(sUV);
        }

        // POST: SUVs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Brand,Model,Engine,HorsePower,MaxSpeed")] SUV sUV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sUV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sUV);
        }

        // GET: SUVs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUV sUV = db.SUVS.Find(id);
            if (sUV == null)
            {
                return HttpNotFound();
            }
            return View(sUV);
        }

        // POST: SUVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SUV sUV = db.SUVS.Find(id);
            db.SUVS.Remove(sUV);
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
