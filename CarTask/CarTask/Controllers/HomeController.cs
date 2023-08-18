using Microsoft.AspNetCore.Mvc;

namespace CarTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
