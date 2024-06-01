using DthLab05_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLab05_1.Controllers
{
    public class DthMemberController : Controller
    {
        // GET: /DthMember/DthCreateOne
        public ActionResult DthCreateOne()
        {
            return View();
        }
        //POST: /DthMember/DthCreateOne
        [HttpPost]
        public ActionResult DthCreateOne(DthMember m)
        {
            return View("DthDetails",m);
        }
        //GET DthCreateTwo
        public ActionResult DthCreateTwo()
        {
            return View();
        }
        //POST DthCreateTwo
        [HttpPost]
        public ActionResult DthCreateTwo(DthMember m)
        {
            if (m.ID == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if(m.DthUserName == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if(m.DthFullName == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.DthPassword == null)
            {
                ViewBag.error = "Hãy nhập Mật khẩu";
                return View();
            }
            if(m.DthAge == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if(m.DthEmail == null)
            {
                ViewBag.error = "Hãy nhập email";
                return View();
            }
            //ktra email
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A+Za-z]{2,4}";
            if(!System.Text.RegularExpressions.Regex.IsMatch(m.DthEmail, regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng email";
                return View();
            }    
            return View("DthDetails",m);
        }
        //GET DthCreateThree
        public ActionResult DthCreateThree()
        {
            return View();
        }
        //POST DthCreateThree
        [HttpPost]
        public ActionResult DthCreateThree(DthMember m)
        {
            //Nếu trạng thái dữ liệu của Model hợp lệ thì chuyển dữ liệu tới DthDetails
            if(ModelState.IsValid)
            {
                return View("DthDetails", m);
            }
            else { return View(); } //quay lại trang báo lỗi
        }
        public ActionResult DthDetails()
        {
            return View() ;
        }
    }
}