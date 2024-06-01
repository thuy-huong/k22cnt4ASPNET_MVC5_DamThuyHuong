using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DthLesson04Demo.Models
{
    public class DthCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBrith { get; set; }

    }
}