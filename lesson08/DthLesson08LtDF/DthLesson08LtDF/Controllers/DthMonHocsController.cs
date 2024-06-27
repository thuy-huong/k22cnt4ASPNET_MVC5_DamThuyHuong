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
    public class DthMonHocsController : Controller
    {
        private Dth_qlSinhVienEntities db = new Dth_qlSinhVienEntities();

        // GET: DthMonHocs
        public ActionResult Index()
        {
            return View(db.DthMonHocs.ToList());
        }

        // GET: DthMonHocs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthMonHoc dthMonHoc = db.DthMonHocs.Find(id);
            if (dthMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dthMonHoc);
        }

        // GET: DthMonHocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DthMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMH,TenMh,SoTiet")] DthMonHoc dthMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.DthMonHocs.Add(dthMonHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dthMonHoc);
        }

        // GET: DthMonHocs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthMonHoc dthMonHoc = db.DthMonHocs.Find(id);
            if (dthMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dthMonHoc);
        }

        // POST: DthMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMH,TenMh,SoTiet")] DthMonHoc dthMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dthMonHoc);
        }

        // GET: DthMonHocs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthMonHoc dthMonHoc = db.DthMonHocs.Find(id);
            if (dthMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dthMonHoc);
        }

        // POST: DthMonHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DthMonHoc dthMonHoc = db.DthMonHocs.Find(id);
            db.DthMonHocs.Remove(dthMonHoc);
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
