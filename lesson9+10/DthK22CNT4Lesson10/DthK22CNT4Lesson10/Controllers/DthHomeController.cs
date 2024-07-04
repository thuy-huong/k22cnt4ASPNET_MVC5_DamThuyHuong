using DthK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthK22CNT4Lesson10.Controllers
{
    public class DthHomeController : Controller
    {
        public ActionResult DthIndex()
        {
            //Kiểm tra dữ liệu trong session
            if (Session["DthAccount"]  != null)
            {
                var dthAccount = Session["DthAccount"] as DthAccount;
                ViewBag.FullName = dthAccount.DthFullName;
            }
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