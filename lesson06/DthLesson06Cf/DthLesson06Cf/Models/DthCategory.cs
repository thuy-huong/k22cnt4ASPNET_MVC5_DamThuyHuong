using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DthLesson06Cf.Models
{
    public class DthCategory
    {
        [Key]
        public int DthId { get; set; }
        public string DthCategoryName { get; set; }

        //Thuộc tính quan hệ
        public virtual ICollection<DthBook> DthBooks { get; set; }


    }
}