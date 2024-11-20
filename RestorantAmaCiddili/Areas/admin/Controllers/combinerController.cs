using Microsoft.AspNetCore.Mvc;

namespace RestorantAmaCiddili.Areas.admin.Controllers
{
    public class combinerController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
