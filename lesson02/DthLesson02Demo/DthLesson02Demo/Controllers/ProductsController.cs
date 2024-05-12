using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson02Demo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products 
        public ActionResult Index()
        {
            ViewBag.Name = "Đàm Thúy Hường - 2210900028";
            return View();
        }
        public ActionResult Details(int? id)
        {
            ViewBag.id = id;    
            return View();
        }
        public string GetName()
        {
            return "Đàm Thúy Hường - 2210900028";
        }
        public JsonResult ListName()
        {
            string[] name = { "Hùng", "Dũng", "Sang", "Trong" };
            return Json(name,JsonRequestBehavior.AllowGet);
        }
    }
}