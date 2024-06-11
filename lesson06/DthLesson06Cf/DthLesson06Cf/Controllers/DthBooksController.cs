using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DthLesson06Cf.Models;

namespace DthLesson06Cf.Controllers
{
    public class DthBooksController : Controller
    {
        private DthBookStore db = new DthBookStore();

        // GET: DthBooks
        public ActionResult Index()
        {
            return View(db.DthBooks.ToList());
        }

        // GET: DthBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthBook dthBook = db.DthBooks.Find(id);
            if (dthBook == null)
            {
                return HttpNotFound();
            }
            return View(dthBook);
        }

        // GET: DthBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DthBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DthId,DthBookId,DthTitle,DthAuthor,DthYear,DthPulisher,DthPicture,DthCategoryId")] DthBook dthBook)
        {
            if (ModelState.IsValid)
            {
                db.DthBooks.Add(dthBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dthBook);
        }

        // GET: DthBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthBook dthBook = db.DthBooks.Find(id);
            if (dthBook == null)
            {
                return HttpNotFound();
            }
            return View(dthBook);
        }

        // POST: DthBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DthId,DthBookId,DthTitle,DthAuthor,DthYear,DthPulisher,DthPicture,DthCategoryId")] DthBook dthBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dthBook);
        }

        // GET: DthBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthBook dthBook = db.DthBooks.Find(id);
            if (dthBook == null)
            {
                return HttpNotFound();
            }
            return View(dthBook);
        }

        // POST: DthBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DthBook dthBook = db.DthBooks.Find(id);
            db.DthBooks.Remove(dthBook);
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
