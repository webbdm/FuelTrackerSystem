using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebbApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FuelEventsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: FuelEvents
        public ActionResult Index()
        {
            return View(db.FuelEvents.ToList());
        }

        // GET: FuelEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelEvent fuelEvent = db.FuelEvents.Find(id);
            if (fuelEvent == null)
            {
                return HttpNotFound();
            }
            return View(fuelEvent);
        }

        // GET: FuelEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuelEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,FuelUsed,Truck,Order,Location")] FuelEvent fuelEvent)
        {
            if (ModelState.IsValid)
            {
                db.FuelEvents.Add(fuelEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuelEvent);
        }

        // GET: FuelEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelEvent fuelEvent = db.FuelEvents.Find(id);
            if (fuelEvent == null)
            {
                return HttpNotFound();
            }
            return View(fuelEvent);
        }

        // POST: FuelEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,FuelUsed,Truck,Order,Location")] FuelEvent fuelEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuelEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuelEvent);
        }

        // GET: FuelEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelEvent fuelEvent = db.FuelEvents.Find(id);
            if (fuelEvent == null)
            {
                return HttpNotFound();
            }
            return View(fuelEvent);
        }

        // POST: FuelEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FuelEvent fuelEvent = db.FuelEvents.Find(id);
            db.FuelEvents.Remove(fuelEvent);
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
