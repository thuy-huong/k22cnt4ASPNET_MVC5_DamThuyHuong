using DthLab03Bai3._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DthLab03Bai3._3.Controllers
{
    public class DthHTMLHelperController : Controller
    {
        // GET: DthHTMLHelper
        public ActionResult FormRegister()
        {
          
            // tạo list cho droplist
            ViewBag.listCountry = new List<DthCountry>() {
                new DthCountry(){ID="0",Name="-- Chọn Quốc Gia --"},
                new DthCountry(){ID="VN",Name="Việt Nam"},
                new DthCountry(){ID="AT",Name="AUSTRALIA"},
                new DthCountry(){ID="UK",Name="Anh"},
                new DthCountry(){ID="FR",Name="Pháp"},
                new DthCountry(){ID="US",Name="Mỹ"},
                new DthCountry(){ID="KP",Name="Hàn Quốc"},
                new DthCountry(){ID="HU",Name="Hồng Kong"},
                new DthCountry(){ID="CN",Name="Trung Quốc"},
            };
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được  các trường đẩy lên server khi submit
            string fvr = "";
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];
            if (Request["Reading"].ToString().Contains("true")) fvr += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true")) fvr += "Shopping ,";
            if (Request["Sport"].ToString().Contains("true")) fvr += "Sport ,";
            TempData["Favourist"] = fvr;
            return View();

        }

    }
}
