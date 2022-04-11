using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Login.Data;
using Login.Models;

namespace Website_GYM.Controllers
{
    public class THIETBIsController : Controller
    {
        private Website_GYMContext db = new Website_GYMContext();

        // GET: THIETBIs
        public ActionResult Index(FormCollection fc)
        {
            string name = fc["k"];

            List<THIETBI> dsaccount = null;
            if (name == null)
            {
                dsaccount = db.THIETBIs.ToList();
                return View(dsaccount);
            }
            else
            {
                dsaccount = db.THIETBIs.Where(x => x.tentb.ToUpper().Contains(name.ToUpper())).ToList();
            }
            return View(dsaccount);
        }

        // GET: THIETBIs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THIETBI tHIETBI = db.THIETBIs.Find(id);
            if (tHIETBI == null)
            {
                return HttpNotFound();
            }
            return View(tHIETBI);
        }

        // GET: THIETBIs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: THIETBIs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "matb,tentb,giatb,soluong")] THIETBI tHIETBI)
        {
            if (ModelState.IsValid)
            {
                db.THIETBIs.Add(tHIETBI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHIETBI);
        }

        // GET: THIETBIs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THIETBI tHIETBI = db.THIETBIs.Find(id);
            if (tHIETBI == null)
            {
                return HttpNotFound();
            }
            return View(tHIETBI);
        }

        // POST: THIETBIs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "matb,tentb,giatb,soluong")] THIETBI tHIETBI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHIETBI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHIETBI);
        }

        // GET: THIETBIs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THIETBI tHIETBI = db.THIETBIs.Find(id);
            if (tHIETBI == null)
            {
                return HttpNotFound();
            }
            return View(tHIETBI);
        }

        // POST: THIETBIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THIETBI tHIETBI = db.THIETBIs.Find(id);
            db.THIETBIs.Remove(tHIETBI);
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
