using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DthLab05_1.Models
{
    public class DthMember
    {
        [Required(ErrorMessage = "Hãy nhập lại mã số")]
        [DataType(DataType.Currency)]
        public int? ID { get; set; }

        [Required(ErrorMessage ="Hãy nhập tên đăng nhập")   ]
        public string DthUserName { get; set; }

        [Required(ErrorMessage = "Hãy nhập họ và tên")]
        public string DthFullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên mật khẩu")]
        public string DthPassword {  get; set; }

        [Required(ErrorMessage = "Hãy nhập tuổi")]
        [Range(18,50,ErrorMessage ="Tuổi t")]
        public int? DthAge { get; set; }

        [Required(ErrorMessage = "Hãy nhập email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A+Za-z]{2,4}",ErrorMessage ="Email phải đúng định dạng")]
        public string DthEmail {  get; set; }
    }
}