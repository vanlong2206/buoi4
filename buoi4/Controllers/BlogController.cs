using Microsoft.AspNetCore.Mvc;

namespace buoi4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
    }
} 