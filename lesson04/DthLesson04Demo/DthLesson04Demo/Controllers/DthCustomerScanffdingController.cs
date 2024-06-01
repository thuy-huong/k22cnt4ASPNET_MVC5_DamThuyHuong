using DthLesson04Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DthLesson04Demo.Controllers
{
    public class DthCustomerScanffdingController : Controller
    {
        //mockData
        private  static List<DthCustomer>listCustomer = new List<DthCustomer>()
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

        // GET: DthCustomerScanffding
        
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
         public ActionResult CreateDth()
        {
            var model = new DthCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateDth(DthCustomer model)
        {
            //thêm mới đố tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);
            //trả về trang danh sách
            return RedirectToAction("Index");
        }

        public ActionResult DthEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);

        }
    }
}