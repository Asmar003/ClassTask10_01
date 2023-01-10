using Microsoft.AspNetCore.Mvc;

namespace ClassTask10_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
