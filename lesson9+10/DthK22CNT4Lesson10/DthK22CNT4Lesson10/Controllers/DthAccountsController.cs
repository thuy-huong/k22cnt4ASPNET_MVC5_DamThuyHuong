using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DthK22CNT4Lesson10.Models;

namespace DthK22CNT4Lesson10.Controllers
{
    public class DthAccountsController : Controller
    {
        private DthK22CNT4Lesson10CbEntities db = new DthK22CNT4Lesson10CbEntities();

        // GET: DthAccounts
        public ActionResult Index()
        {
            return View(db.DthAccounts.ToList());
        }

        // GET: DthAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthAccount dthAccount = db.DthAccounts.Find(id);
            if (dthAccount == null)
            {
                return HttpNotFound();
            }
            return View(dthAccount);
        }

        // GET: DthAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DthAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DthId,DthUserName,DthPassword,DthFullName,DthEmail,DthPhone,DthActive")] DthAccount dthAccount)
        {
            if (ModelState.IsValid)
            {
                db.DthAccounts.Add(dthAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dthAccount);
        }

        // GET: DthAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthAccount dthAccount = db.DthAccounts.Find(id);
            if (dthAccount == null)
            {
                return HttpNotFound();
            }
            return View(dthAccount);
        }

        // POST: DthAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DthId,DthUserName,DthPassword,DthFullName,DthEmail,DthPhone,DthActive")] DthAccount dthAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dthAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dthAccount);
        }

        // GET: DthAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DthAccount dthAccount = db.DthAccounts.Find(id);
            if (dthAccount == null)
            {
                return HttpNotFound();
            }
            return View(dthAccount);
        }

        // POST: DthAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DthAccount dthAccount = db.DthAccounts.Find(id);
            db.DthAccounts.Remove(dthAccount);
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

        // Login
        public ActionResult DthLogin()
        {
            var dthModel = new DthAccount();
            return View(dthModel);
        }
        [HttpPost]
        public ActionResult DthLogin(DthAccount dthAccount)
        {
            var dthCheck = db.DthAccounts.Where(x=>x.DthUserName.Equals(dthAccount.DthUserName) && x.DthPassword.Equals(dthAccount.DthPassword)).FirstOrDefault();
            if (dthCheck != null)
            {
                //Lưu session
                Session["DthAccount"] = dthCheck;
                return Redirect("/");
            }
            return View(dthAccount);
        }
    }
}
