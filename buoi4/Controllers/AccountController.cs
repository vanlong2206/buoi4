using Microsoft.AspNetCore.Mvc;

namespace buoi4.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 