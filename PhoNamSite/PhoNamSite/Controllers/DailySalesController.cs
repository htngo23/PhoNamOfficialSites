using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhoNamSite.Models;

namespace PhoNamSite.Controllers
{
    public class DailySalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DailySales
        public ActionResult Index()
        {
            var dailySales = db.DailySaless;
            return View(dailySales.ToList());
        }

        // GET: DailySales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySales dailySales = db.DailySaless.Find(id);
            if (dailySales == null)
            {
                return HttpNotFound();
            }
            return View(dailySales);
        }

        // GET: DailySales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailySales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Day,Date,DailyTotal")] DailySales dailySales)
        {
            if (ModelState.IsValid)
            {
                db.DailySaless.Add(dailySales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailySales);
        }

        // GET: DailySales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySales dailySales = db.DailySaless.Find(id);
            if (dailySales == null)
            {
                return HttpNotFound();
            }
            return View(dailySales);
        }

        // POST: DailySales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Day,Date,DailyTotal")] DailySales dailySales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailySales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailySales);
        }

        // GET: DailySales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySales dailySales = db.DailySaless.Find(id);
            if (dailySales == null)
            {
                return HttpNotFound();
            }
            return View(dailySales);
        }

        // POST: DailySales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailySales dailySales = db.DailySaless.Find(id);
            db.DailySaless.Remove(dailySales);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Graphs()
        {
            return View(db.DailySaless.ToList());
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
