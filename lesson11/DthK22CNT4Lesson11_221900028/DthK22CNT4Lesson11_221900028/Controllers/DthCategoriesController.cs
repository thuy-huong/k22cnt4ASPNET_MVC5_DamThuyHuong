using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DthK22CNT4Lesson11_221900028.Models;

namespace DthK22CNT4Lesson11_221900028.Controllers
{
    public class DthCategoriesController : Controller
    {
        private DthK22CNT4Lesson11DbEntities db = new DthK22CNT4Lesson11DbEntities();

        // GET: DthCategories
        public ActionResult DthIndex()
        {
            return View(db.DthCategories.ToList());
        }

        // GET: DthCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthCategory dthCategory = db.DthCategories.Find(id);
            if (dthCategory == null)
            {
                return HttpNotFound();
            }
            return View(dthCategory);
        }

        // GET: DthCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DthCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DthID,DthCateName,DthStatus")] DthCategory dthCategory)
        {
            if (ModelState.IsValid)
            {
                db.DthCategories.Add(dthCategory);
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }

            return View(dthCategory);
        }

        // GET: DthCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthCategory dthCategory = db.DthCategories.Find(id);
            if (dthCategory == null)
            {
                return HttpNotFound();
            }
            return View(dthCategory);
        }

        // POST: DthCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DthID,DthCateName,DthStatus")] DthCategory dthCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DthIndex");
            }
            return View(dthCategory);
        }

        // GET: DthCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthCategory dthCategory = db.DthCategories.Find(id);
            if (dthCategory == null)
            {
                return HttpNotFound();
            }
            return View(dthCategory);
        }

        // POST: DthCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DthCategory dthCategory = db.DthCategories.Find(id);
            db.DthCategories.Remove(dthCategory);
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
