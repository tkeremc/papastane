using Microsoft.AspNetCore.Mvc;

namespace RestorantAmaCiddili.Areas.musteri.Controllers
{
    public class contactController : Controller
    {
        [Area("musteri")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
