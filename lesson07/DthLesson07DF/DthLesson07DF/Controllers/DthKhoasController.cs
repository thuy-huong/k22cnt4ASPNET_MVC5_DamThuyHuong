using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DthLesson07DF.Models;

namespace DthLesson07DF.Controllers
{
    public class DthKhoasController : Controller
    {
        private DthK22CNT4Lesson07DbEntities db = new DthK22CNT4Lesson07DbEntities();

        // GET: DthKhoas
        public ActionResult DthIndex()
        {
            return View(db.dthKhoas.ToList());
        }

        // GET: DthKhoas/Details/5
        public ActionResult DthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoas.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // GET: DthKhoas/Create
        public ActionResult DthCreate()
        {
            return View();
        }

        // POST: DthKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthCreate([Bind(Include = "DthMaKhoa,DthTenKhoa,DthTrangThai")] dthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dthKhoas.Add(dthKhoa);
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }

            return View(dthKhoa);
        }

        // GET: DthKhoas/Edit/5
        public ActionResult DthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoas.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // POST: DthKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthEdit([Bind(Include = "DthMaKhoa,DthTenKhoa,DthTrangThai")] dthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }
            return View(dthKhoa);
        }

        // GET: DthKhoas/Delete/5
        public ActionResult DthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthKhoa dthKhoa = db.dthKhoas.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // POST: DthKhoas/Delete/5
        [HttpPost, ActionName("DthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dthKhoa dthKhoa = db.dthKhoas.Find(id);
            db.dthKhoas.Remove(dthKhoa);
            db.SaveChanges();
            return RedirectToAction("DthIndex");
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
