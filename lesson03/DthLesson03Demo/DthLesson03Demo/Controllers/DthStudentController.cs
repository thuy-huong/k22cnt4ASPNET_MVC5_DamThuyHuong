using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson03Demo.Controllers
{
    public class DthStudentController : Controller
    {
        // GET: DthStudent
        public ActionResult Index()
        {
            ///dữ liệu từ ViewData
            ViewData["msg"] = "View Data - Đàm Thúy Hường";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yy");
            return View();
        }
        public ActionResult StudentList()
        {
            ///Sử dụng ViewBag
            /////Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Đàm Thúy Hường";
            //Lưu trữ 1 tập hợp
            String[] names = { "Thúy Hường", "Trần Tiến", "Tạ Hồng", "Diễm Hương", "Vương Định" };
            ViewBag.list = names;
            //Giá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name = "Thúy Hường",
                Age = 20

            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}