﻿using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Listing()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
