using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
