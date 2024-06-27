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
    public class DthKhoasController : Controller
    {
        private Dth_qlSinhVienEntities db = new Dth_qlSinhVienEntities();

        // GET: DthKhoas
        public ActionResult Index()
        {
            return View(db.DthKhoas.ToList());
        }

        // GET: DthKhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKhoa dthKhoa = db.DthKhoas.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // GET: DthKhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DthKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKH,TenKH")] DthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.DthKhoas.Add(dthKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dthKhoa);
        }

        // GET: DthKhoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKhoa dthKhoa = db.DthKhoas.Find(id);
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
        public ActionResult Edit([Bind(Include = "MaKH,TenKH")] DthKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dthKhoa);
        }

        // GET: DthKhoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthKhoa dthKhoa = db.DthKhoas.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dthKhoa);
        }

        // POST: DthKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DthKhoa dthKhoa = db.DthKhoas.Find(id);
            db.DthKhoas.Remove(dthKhoa);
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
