using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DthLesson08LtDF.Models;

namespace DthLesson08LtDF.Controllers
{
    public class DthSinhViensController : Controller
    {
        private Dth_qlSinhVienEntities db = new Dth_qlSinhVienEntities();

        // GET: DthSinhViens
        public ActionResult Index()
        {
            var dthSinhViens = db.DthSinhViens.Include(d => d.DthKhoa);
            return View(dthSinhViens.ToList());
        }

        // GET: DthSinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthSinhVien dthSinhVien = db.DthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.DthKhoas, "MaKH", "TenKH");
            return View();
        }

        // POST: DthSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTrungBinh")] DthSinhVien dthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.DthSinhViens.Add(dthSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKH = new SelectList(db.DthKhoas, "MaKH", "TenKH", dthSinhVien.MaKH);
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthSinhVien dthSinhVien = db.DthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.DthKhoas, "MaKH", "TenKH", dthSinhVien.MaKH);
            return View(dthSinhVien);
        }

        // POST: DthSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTrungBinh")] DthSinhVien dthSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.DthKhoas, "MaKH", "TenKH", dthSinhVien.MaKH);
            return View(dthSinhVien);
        }

        // GET: DthSinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthSinhVien dthSinhVien = db.DthSinhViens.Find(id);
            if (dthSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dthSinhVien);
        }

        // POST: DthSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DthSinhVien dthSinhVien = db.DthSinhViens.Find(id);
            db.DthSinhViens.Remove(dthSinhVien);
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
