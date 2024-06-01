using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DthLesson05Demo.Models
{
    public class DthSong
    {
        [Key ]
        public int Id { get; set; }

        [Required(ErrorMessage ="Dth: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string DthTitle { get; set; }

        [Required(ErrorMessage = "Dth: Hãy nhập tên tác giả")]
        [DisplayName("Tác giả")]
        public string DthAuthor { get; set; }

        [Required(ErrorMessage = "Dth: Hãy nhập nghệ sĩ")]
        [DisplayName("Nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Dth: Tên nghệ sĩ có tối thiểu 2 kí tự, tối đa 50 kí tự")]
        public string DthArtist { get; set;}

        [Required(ErrorMessage = "Dth: Hãy nhập năm xuất bản")]
        [DisplayName("Năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage="Dth: Năm xuất bản phải có tối đa 4 kí tự số")]
        [Range(1900,2024,ErrorMessage = "Dth: Năm xuất bản trong khoảng 1900-2024")]
        public int DthYearlekease { get; set;}
    }
}