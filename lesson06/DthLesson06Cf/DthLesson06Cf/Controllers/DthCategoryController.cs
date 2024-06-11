using DthLesson06Cf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson06Cf.Controllers
{
    public class DthCategoryController : Controller
    {
        private static DthBookStore DthDb;
        public DthCategoryController()
        {
            DthDb = new DthBookStore();
        }
        // GET: DthCategory
        public ActionResult DthIndex()
        {
            /*
             * Khơi tạo DbContext:
             * EF tìm thôn tin kết nối trong file machinee.config của .NET Framework trên máy 
             * và sau đó tại csdl
             */
            //DthBookStore DthDb = new DthBookStore();
            var DthCategories = DthDb.DthCategories.ToList();
            return View(DthCategories);
        }
        public ActionResult DthCreate()
        {
            var DthCategory = new DthCategory();
            return View(DthCategory);
        }
        [HttpPost]
        public ActionResult DthCreate(DthCategory dthCategory)
        {
            DthDb.DthCategories.Add(dthCategory);
            DthDb.SaveChanges();
            return RedirectToAction("DthIndex");
        }
    }
}