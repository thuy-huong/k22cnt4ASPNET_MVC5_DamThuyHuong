using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson07DF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DthIndex()
        {
            return View();
        }

        public ActionResult DthAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DthContact()
        {
            ViewBag.Message = "Đây là page của Đàm Thúy Hường.";

            return View();
        }
    }
}