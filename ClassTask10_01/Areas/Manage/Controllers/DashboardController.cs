using Microsoft.AspNetCore.Mvc;

namespace ClassTask10_01.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
