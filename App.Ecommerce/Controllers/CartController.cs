using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
