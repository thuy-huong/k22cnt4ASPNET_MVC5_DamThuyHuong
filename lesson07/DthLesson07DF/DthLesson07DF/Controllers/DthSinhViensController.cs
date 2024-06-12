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
    public class DthSinhViensController : Controller
    {
        private DthK22CNT4Lesson07DbEntities db = new DthK22CNT4Lesson07DbEntities();

        // GET: DthSinhViens
        public ActionResult DthIndex()
        {
            var dthSinhViens = db.dthSinhViens.Include(d => d.dthKhoa);
            return View(dthSinhViens.ToList());
        }

        // GET: DthSinhViens/Details/5
        public ActionResult DthDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthSinhVien dthSinhVien = db.dthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Create
        public ActionResult DthCreate()
        {
            ViewBag.DthMaKh = new SelectList(db.dthKhoas, "DthMaKhoa", "DthTenKhoa");
            return View();
        }

        // POST: DthSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthCreate([Bind(Include = "DthMaSV,DthHoSV,DthTenSV,DthNgaySinh,DthPhai,DthPhone,DthEmail,DthMaKh")] dthSinhVien dthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.dthSinhViens.Add(dthSinhVien);
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }

            ViewBag.DthMaKh = new SelectList(db.dthKhoas, "DthMaKhoa", "DthTenKhoa", dthSinhVien.DthMaKh);
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Edit/5
        public ActionResult DthEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthSinhVien dthSinhVien = db.dthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.DthMaKh = new SelectList(db.dthKhoas, "DthMaKhoa", "DthTenKhoa", dthSinhVien.DthMaKh);
            return View(dthSinhVien);
        }

        // POST: DthSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthEdit([Bind(Include = "DthMaSV,DthHoSV,DthTenSV,DthNgaySinh,DthPhai,DthPhone,DthEmail,DthMaKh")] dthSinhVien dthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }
            ViewBag.DthMaKh = new SelectList(db.dthKhoas, "DthMaKhoa", "DthTenKhoa", dthSinhVien.DthMaKh);
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Delete/5
        public ActionResult DthDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dthSinhVien dthSinhVien = db.dthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dthSinhVien);
        }

        // POST: DthSinhViens/Delete/5
        [HttpPost, ActionName("DthDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dthSinhVien dthSinhVien = db.dthSinhViens.Find(id);
            db.dthSinhViens.Remove(dthSinhVien);
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
