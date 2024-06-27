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
    public class DthKetQuasController : Controller
    {
        private Dth_qlSinhVienEntities db = new Dth_qlSinhVienEntities();

        // GET: DthKetQuas
        public ActionResult Index()
        {
            var dthKetQuas = db.DthKetQuas.Include(d => d.DthMonHoc).Include(d => d.DthSinhVien);
            return View(dthKetQuas.ToList());
        }

        // GET: DthKetQuas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKetQua dthKetQua = db.DthKetQuas.Find(id);
            if (dthKetQua == null)
            {
                return HttpNotFound();
            }
            return View(dthKetQua);
        }

        // GET: DthKetQuas/Create
        public ActionResult Create()
        {
            ViewBag.MaMH = new SelectList(db.DthMonHocs, "MaMH", "TenMh");
            ViewBag.MaSV = new SelectList(db.DthSinhViens, "MaSV", "HoSV");
            return View();
        }

        // POST: DthKetQuas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKQ,MaSV,MaMH,Diem")] DthKetQua dthKetQua)
        {
            if (ModelState.IsValid)
            {
                db.DthKetQuas.Add(dthKetQua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMH = new SelectList(db.DthMonHocs, "MaMH", "TenMh", dthKetQua.MaMH);
            ViewBag.MaSV = new SelectList(db.DthSinhViens, "MaSV", "HoSV", dthKetQua.MaSV);
            return View(dthKetQua);
        }

        // GET: DthKetQuas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKetQua dthKetQua = db.DthKetQuas.Find(id);
            if (dthKetQua == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMH = new SelectList(db.DthMonHocs, "MaMH", "TenMh", dthKetQua.MaMH);
            ViewBag.MaSV = new SelectList(db.DthSinhViens, "MaSV", "HoSV", dthKetQua.MaSV);
            return View(dthKetQua);
        }

        // POST: DthKetQuas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKQ,MaSV,MaMH,Diem")] DthKetQua dthKetQua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthKetQua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMH = new SelectList(db.DthMonHocs, "MaMH", "TenMh", dthKetQua.MaMH);
            ViewBag.MaSV = new SelectList(db.DthSinhViens, "MaSV", "HoSV", dthKetQua.MaSV);
            return View(dthKetQua);
        }

        // GET: DthKetQuas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKetQua dthKetQua = db.DthKetQuas.Find(id);
            if (dthKetQua == null)
            {
                return HttpNotFound();
            }
            return View(dthKetQua);
        }

        // POST: DthKetQuas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DthKetQua dthKetQua = db.DthKetQuas.Find(id);
            db.DthKetQuas.Remove(dthKetQua);
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
