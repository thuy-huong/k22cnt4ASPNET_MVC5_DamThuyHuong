using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DthLesson06Cf.Models
{
    public class DthBookStore:DbContext
    {
        public DthBookStore():base("DthBookStoreConnectionString") { }

        //khai báo các thuộc tính tương ứng với csdl
        public DbSet<DthCategory> DthCategories { get; set; }
        public DbSet<DthBook> DthBooks { get; set; }
    }
}