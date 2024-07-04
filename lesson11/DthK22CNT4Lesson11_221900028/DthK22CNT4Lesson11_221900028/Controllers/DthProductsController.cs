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
    public class DthProductsController : Controller
    {
        private DthK22CNT4Lesson11DbEntities db = new DthK22CNT4Lesson11DbEntities();

        // GET: DthProducts
        public ActionResult Index()
        {
            var dthProducts = db.DthProducts.Include(d => d.DthCategory);
            return View(dthProducts.ToList());
        }

        // GET: DthProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthProduct dthProduct = db.DthProducts.Find(id);
            if (dthProduct == null)
            {
                return HttpNotFound();
            }
            return View(dthProduct);
        }

        // GET: DthProducts/Create
        public ActionResult Create()
        {
            ViewBag.DthCateId = new SelectList(db.DthCategories, "DthID", "DthCateName");
            return View();
        }

        // POST: DthProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DthId,DthProName,DthQty,Dthprice,DthCateId,DthActive")] DthProduct dthProduct)
        {
            if (ModelState.IsValid)
            {
                db.DthProducts.Add(dthProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DthCateId = new SelectList(db.DthCategories, "DthID", "DthCateName", dthProduct.DthCateId);
            return View(dthProduct);
        }

        // GET: DthProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthProduct dthProduct = db.DthProducts.Find(id);
            if (dthProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.DthCateId = new SelectList(db.DthCategories, "DthID", "DthCateName", dthProduct.DthCateId);
            return View(dthProduct);
        }

        // POST: DthProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DthId,DthProName,DthQty,Dthprice,DthCateId,DthActive")] DthProduct dthProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DthCateId = new SelectList(db.DthCategories, "DthID", "DthCateName", dthProduct.DthCateId);
            return View(dthProduct);
        }

        // GET: DthProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthProduct dthProduct = db.DthProducts.Find(id);
            if (dthProduct == null)
            {
                return HttpNotFound();
            }
            return View(dthProduct);
        }

        // POST: DthProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DthProduct dthProduct = db.DthProducts.Find(id);
            db.DthProducts.Remove(dthProduct);
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
