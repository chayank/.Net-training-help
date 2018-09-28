using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class tblStocksController : Controller
    {
        private StpDBEntities db = new StpDBEntities();

        // GET: tblStocks
        public ActionResult Index()
        {
            var tblStocks = db.tblStocks.Include(t => t.tblUser);
            return View(tblStocks.ToList());
        }

        // GET: tblStocks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStock tblStock = db.tblStocks.Find(id);
            if (tblStock == null)
            {
                return HttpNotFound();
            }
            return View(tblStock);
        }

        // GET: tblStocks/Create
        public ActionResult Create()
        {
            ViewBag.addedBy = new SelectList(db.tblUsers, "uid", "fname");
            return View();
        }

        // POST: tblStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "stockId,stockName,quantity,quantity_remaining,addedBy,status")] tblStock tblStock)
        {
            if (ModelState.IsValid)
            {
                db.tblStocks.Add(tblStock);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.addedBy = new SelectList(db.tblUsers, "uid", "fname", tblStock.addedBy);
            return View(tblStock);
        }

        // GET: tblStocks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStock tblStock = db.tblStocks.Find(id);
            if (tblStock == null)
            {
                return HttpNotFound();
            }
            ViewBag.addedBy = new SelectList(db.tblUsers, "uid", "fname", tblStock.addedBy);
            return View(tblStock);
        }

        // POST: tblStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "stockId,stockName,quantity,quantity_remaining,addedBy,status")] tblStock tblStock)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblStock).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.addedBy = new SelectList(db.tblUsers, "uid", "fname", tblStock.addedBy);
            return View(tblStock);
        }

        // GET: tblStocks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStock tblStock = db.tblStocks.Find(id);
            if (tblStock == null)
            {
                return HttpNotFound();
            }
            return View(tblStock);
        }

        // POST: tblStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblStock tblStock = db.tblStocks.Find(id);
            db.tblStocks.Remove(tblStock);
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
