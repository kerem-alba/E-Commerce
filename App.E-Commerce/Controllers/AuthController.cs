using App.E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Ecommerce.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [Route("/login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/login")]
        [HttpPost]
        public IActionResult Login([FromForm] LoginViewModel loginModel)
        {
            return View();
        }

        [Route("/forgot-password")]
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        } 

        public IActionResult Logout()
        {
            return View();
        }
    }
}
