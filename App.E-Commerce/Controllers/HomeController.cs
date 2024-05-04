﻿using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/about-us")]
        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Route("/contact")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/product/list")]
        [HttpGet]
        public IActionResult Listing()
        {
            return View();
        }

        [Route("/product/{productId:int}/details")]
        [HttpGet]
        public IActionResult ProductDetail([FromRoute] int productId)
        {
            return View();
        }
    }
}
