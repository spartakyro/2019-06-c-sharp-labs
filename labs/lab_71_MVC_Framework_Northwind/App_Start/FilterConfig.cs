﻿using System.Web;
using System.Web.Mvc;

namespace lab_71_MVC_Framework_Northwind
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
