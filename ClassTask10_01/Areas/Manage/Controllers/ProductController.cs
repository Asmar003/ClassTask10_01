using ClassTask10_01.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ClassTask10_01.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return View(context.Products.ToList());
            }
        }
        public IActionResult Update
    }
}
