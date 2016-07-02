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
    public class OrderManagerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrderManager
        public ActionResult Index()
        {
            var menuProducts = db.MenuProducts.Include(m => m.Category);
            return View(menuProducts.ToList());
        }

        // GET: OrderManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuProduct menuProduct = db.MenuProducts.Find(id);
            if (menuProduct == null)
            {
                return HttpNotFound();
            }
            return View(menuProduct);
        }

        // GET: OrderManager/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: OrderManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,MenuID,ProductName,Description,UnitPrice,ImagePath,CategoryID")] MenuProduct menuProduct)
        {
            if (ModelState.IsValid)
            {
                db.MenuProducts.Add(menuProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", menuProduct.CategoryID);
            return View(menuProduct);
        }

        // GET: OrderManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuProduct menuProduct = db.MenuProducts.Find(id);
            if (menuProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", menuProduct.CategoryID);
            return View(menuProduct);
        }

        // POST: OrderManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,MenuID,ProductName,Description,UnitPrice,ImagePath,CategoryID")] MenuProduct menuProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", menuProduct.CategoryID);
            return View(menuProduct);
        }

        // GET: OrderManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuProduct menuProduct = db.MenuProducts.Find(id);
            if (menuProduct == null)
            {
                return HttpNotFound();
            }
            return View(menuProduct);
        }

        // POST: OrderManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuProduct menuProduct = db.MenuProducts.Find(id);
            db.MenuProducts.Remove(menuProduct);
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
