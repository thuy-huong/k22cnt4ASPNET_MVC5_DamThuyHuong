using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson08LtDF.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}