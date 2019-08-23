using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_74_b.Models;

namespace lab_74_b.Pages
{
    public class NorthwindModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();
        public void OnGet()
        {
            

            using(var db = new Northwind())
            {
                customers = db.customers.ToList();

            }



        }
    }
}