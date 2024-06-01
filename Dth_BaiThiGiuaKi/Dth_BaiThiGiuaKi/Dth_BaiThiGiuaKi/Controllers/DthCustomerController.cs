using Dth_BaiThiGiuaKi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Dth_BaiThiGiuaKi.Controllers
{
    public class DthCustomerController : Controller
    {
        private static List<DthCustomer> DthCustomer = new List<DthCustomer>()
        {
            new DthCustomer{Dth_2210900028_CustId = "2210900028",
                Dth_FullName = "Đàm Thúy Hường",
                Dth_Address = "Sóc Sơn, Hà nội",
                Dth_Email = "Thuyhuong31804@gmail.com",
                Dth_Phone = "0962169464",
                Dth_Balance = 1
            },
             new DthCustomer{Dth_2210900028_CustId = "2",
                Dth_FullName = "Nguyễn Minh Phương",
                Dth_Address = "Phú Thọ",
                Dth_Email = "Minhphuong@gmail.com",
                Dth_Phone = "0912358902",
                Dth_Balance = 1
            },
              new DthCustomer{Dth_2210900028_CustId = "3",
                Dth_FullName = "Nguyễn Bá an",
                Dth_Address = "Hải Dương",
                Dth_Email = "baan@gmail.com",
                Dth_Phone = "0123658947",
                Dth_Balance = 0
            },
               new DthCustomer{Dth_2210900028_CustId = "4",
                Dth_FullName = "Nguyễn Thị Thanh An",
                Dth_Address = "Hà nội",
                Dth_Email = "Thanhan@gmail.com",
                Dth_Phone = "0325698532",
                Dth_Balance = 1
            },
                new DthCustomer{Dth_2210900028_CustId = "5",
                Dth_FullName = "Đinh Thị Như Hương",
                Dth_Address = "Hà Nội",
                Dth_Email = "Dtnh@gmail.com",
                Dth_Phone = "0365214741",
                Dth_Balance = 1
            },
        };

        // GET: DthCustomer
        /// <summary>
        /// Hiển thị danh sách khách hàng 
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <returns></returns>
        public ActionResult DthIndex()
        {
            return View(DthCustomer);
        }

        //GET: DthCreate
        /// <summary>
        /// Xem thông khách hàng
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <returns></returns>
        public ActionResult DthCreate(string id)
        {
            var customer = DthCustomer.FirstOrDefault(x=>x.Dth_2210900028_CustId == id);
            return View(customer);
        }


        //GET: DthDetail
        /// <summary>
        /// Thêm thông tin khách hàng
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <returns></returns>

        public ActionResult DthDetail()
        {
            var dthCus = new DthCustomer();
            return View(dthCus);
        }
        [HttpPost]
        public ActionResult DthDetail(DthCustomer customer)
        {
            DthCustomer.Add(customer);
            return RedirectToAction("DthIndex");
        }

        //Get DthEdit
        /// <summary>
        /// Chỉnh sửa thông tin khách hàng
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DthEdit(string id)
        {
            var customer = DthCustomer.FirstOrDefault(x => x.Dth_2210900028_CustId == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult DthEdit(DthCustomer customer)
        {
            var DthCus = DthCustomer.FirstOrDefault(x => x.Dth_2210900028_CustId == customer.Dth_2210900028_CustId);

            DthCus.Dth_2210900028_CustId = customer.Dth_2210900028_CustId;
            DthCus.Dth_FullName = customer.Dth_FullName;
            DthCus.Dth_Address = customer.Dth_Address;
            DthCus.Dth_Email = customer.Dth_Email;
            DthCus.Dth_Phone = customer.Dth_Phone;
            DthCus.Dth_Balance = customer.Dth_Balance;

            return RedirectToAction("DthIndex");
        }

        //GET DthDelete
        /// <summary>
        /// xóa Thông tin khách hàng
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DthDelete(string id)
        {
            var customer = DthCustomer.FirstOrDefault(x => x.Dth_2210900028_CustId == id);
            // Xóa 
            DthCustomer.Remove(customer);
            return RedirectToAction("DthIndex");
        }
    }
}