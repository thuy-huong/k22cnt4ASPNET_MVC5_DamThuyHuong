using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DthLesson06Cf.Models
{
    public class DthBook
    {
        [Key] 
        public int DthId { get; set; }
        public string DthBookId { get; set; }
        public string DthTitle { get; set; }
        public string DthAuthor { get; set; }
        public int DthYear { get; set;}
        public string DthPulisher { get; set;}
        public string DthPicture{ get; set; }
        public int DthCategoryId { get; set; }
        //Thuộc tính quan hệ
        public virtual DthCategory DthCategory { get; set; }
    }
}