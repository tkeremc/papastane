using Microsoft.AspNetCore.Mvc;

namespace RestorantAmaCiddili.Areas.musteri.Controllers
{
    public class aboutController : Controller
    {
        [Area("musteri")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
