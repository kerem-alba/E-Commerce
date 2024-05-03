using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
