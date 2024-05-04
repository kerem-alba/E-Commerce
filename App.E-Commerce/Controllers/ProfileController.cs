using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult MyOrders()
        {
            return View();
        }

        public IActionResult MyProducts()
        {
            return View();
        }
    }
}
