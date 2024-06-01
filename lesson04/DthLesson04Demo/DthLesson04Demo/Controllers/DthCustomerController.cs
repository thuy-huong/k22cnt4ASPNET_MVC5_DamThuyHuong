using DthLesson04Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLesson04Demo.Controllers
{
    public class DthCustomerController : Controller
    {
        // GET: DthCustomer
        public ActionResult Index()
        {
            return View();
        }
        ///Action : DthCustomerDetail
        public ActionResult DthCustomerDetails()
        {
            //Tạo đối tượng dữ liệu
            var customer = new DthCustomer()
            {
                CustomerId = 1,
                FirstName = "Đàm Thúy ",
                LastName = "Hường",
                Address = "K22CNT4",
                YearOfBrith = 2004
            };
            ViewBag.Customer = customer;  
            return View();

        }
        //Get: DthListCustomer
        public ActionResult DthListCustomer()
        {
            var list = new List<DthCustomer>()
            {
                new DthCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Đàm Thúy ",
                    LastName = "Hường",
                    Address = "K22CNT4",
                    YearOfBrith = 2004
                },
                new DthCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Đàm Vĩnh",
                    LastName = "Trinh",
                    Address = "K22CNT4",
                    YearOfBrith = 2004
                },
                 new DthCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Đàm Vĩnh",
                    LastName = "Trinh 1",
                    Address = "K22CNT4",
                    YearOfBrith = 2004
                },
                  new DthCustomer()
                {
                    CustomerId = 4,
                    FirstName = "Đàm Vĩnh",
                    LastName = "Trinh 2",
                    Address = "K22CNT4",
                    YearOfBrith = 2004
                },
            };
            //ViewBag.list = list;
             return View(list);
        }
    }
}