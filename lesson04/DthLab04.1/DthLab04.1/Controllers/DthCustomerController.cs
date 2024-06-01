using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using DthLab04._1.Models;

namespace DthLab04._1.Controllers
{
    public class DthCustomerController : Controller
    {
        // GET: DthCustomer
        public ActionResult DthCustomerDetails()
        {
            //tạo một đối tượng Customer
            DthCustomer cus = new DthCustomer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(cus);
        }
        public ActionResult DthCustomerList()
        {
            //tạo một danh sách khách hàng
            List<DthCustomer> list = new List<DthCustomer>() {
            new DthCustomer { CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội", Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889", Balance = 15200000 },
            new DthCustomer {CustomerId = "KH002", 
                FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",Email = "cucdt@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
            new DthCustomer {CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",Email = "thangnt@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
            new DthCustomer {CustomerId = "KH004", 
                FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",Email = "hailn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
            };
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}