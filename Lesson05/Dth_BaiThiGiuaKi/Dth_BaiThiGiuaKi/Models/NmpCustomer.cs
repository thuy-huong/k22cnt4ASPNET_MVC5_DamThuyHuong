using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dth_BaiThiGiuaKi.Models
{
    public class DthCustomer
    {
        [Required(ErrorMessage = "Hãy nhập  mã khách hàng")]
        [DisplayName("Mã khách hàng")]
        [DataType(DataType.Currency)]
        public string Dth_2210900028_CustId { get; set; }

        [Required(ErrorMessage = "Hãy nhập Họ và tên")]
        [DisplayName("Họ và tên")]
        [DataType(DataType.Currency)]
        public string Dth_FullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        [DataType(DataType.Currency)]
        public string Dth_Address { get; set; }

        [Required(ErrorMessage = "Hãy nhập email")]
        [DisplayName("Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A+Za-z]{2,4}", ErrorMessage = "Email phải đúng định dạng")]
        public string Dth_Email { get; set; }

        [Required(ErrorMessage = "Hãy nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Số điện thoại phải có tối đa 10 kí tự số")]
        public string Dth_Phone { get; set; }

        [Required(ErrorMessage = "Hãy nhập Balance")]
        public int Dth_Balance { get; set; }
    }
}