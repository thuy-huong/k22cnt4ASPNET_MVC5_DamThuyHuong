﻿using System.Web;
using System.Web.Mvc;

namespace Lab02Bai2._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
