using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthK22CNT4Lesson11_221900028.Controllers
{
    public class DthHomeController : Controller
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
            ViewBag.msv = "2210900028";
            ViewBag.fullName = "Đàm Thúy Hường";
            return View();
        }
    }
}