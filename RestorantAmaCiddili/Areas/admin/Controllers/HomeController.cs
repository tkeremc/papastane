using Microsoft.AspNetCore.Mvc;

namespace RestorantAmaCiddili.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
    }
}
