using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KITABLARRR.Models;

namespace KITABLARRR.Controllers
{
    public class KITABLARsController : Controller
    {
        private ORIENTDBEntities db = new ORIENTDBEntities();

        // GET: KITABLARs
        public ActionResult Index()
        {
            return View(db.KITABLARs.ToList());
        }

        // GET: KITABLARs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KITABLAR kITABLAR = db.KITABLARs.Find(id);
            if (kITABLAR == null)
            {
                return HttpNotFound();
            }
            return View(kITABLAR);
        }

        // GET: KITABLARs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KITABLARs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,KITAB_AD,KITAB_YAZAR,KITAB_SEHIFE,KITAB_QIYMET,KITAB_TARIX,KITAB_CAPEV")] KITABLAR kITABLAR)
        {
            if (ModelState.IsValid)
            {
                db.KITABLARs.Add(kITABLAR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kITABLAR);
        }

        // GET: KITABLARs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KITABLAR kITABLAR = db.KITABLARs.Find(id);
            if (kITABLAR == null)
            {
                return HttpNotFound();
            }
            return View(kITABLAR);
        }

        // POST: KITABLARs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,KITAB_AD,KITAB_YAZAR,KITAB_SEHIFE,KITAB_QIYMET,KITAB_TARIX,KITAB_CAPEV")] KITABLAR kITABLAR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kITABLAR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kITABLAR);
        }

        // GET: KITABLARs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KITABLAR kITABLAR = db.KITABLARs.Find(id);
            if (kITABLAR == null)
            {
                return HttpNotFound();
            }
            return View(kITABLAR);
        }

        // POST: KITABLARs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KITABLAR kITABLAR = db.KITABLARs.Find(id);
            db.KITABLARs.Remove(kITABLAR);
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
