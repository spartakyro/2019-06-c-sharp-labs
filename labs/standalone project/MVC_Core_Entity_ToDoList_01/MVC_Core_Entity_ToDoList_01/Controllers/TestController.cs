using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Controllers
{
    
    public class TestController : Controller
    {
       
        public IActionResult Index()
        {
            var instance = new Lists();
            instance.stringList = new List<string>() { "one", "two", "three" };
            instance.publicCeleb =  "christian bale";
            instance.ageing = 42;
            return View(instance);

           
        }
    }
}