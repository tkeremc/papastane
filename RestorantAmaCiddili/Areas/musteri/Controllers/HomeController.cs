using Microsoft.AspNetCore.Mvc;

namespace RestorantAmaCiddili.Areas.musteri.Controllers
{
    public class HomeController : Controller
    {
        [Area("musteri")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult menu()
        {
            return View();
        }
    }
}
