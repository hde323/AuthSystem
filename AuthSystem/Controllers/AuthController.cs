using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signu() 
        {
            return View();
        }
        public IActionResult Verify()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}