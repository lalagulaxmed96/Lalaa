﻿
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eflyer.Controllers
{
    public class HomeController : Controller
    {
     

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
