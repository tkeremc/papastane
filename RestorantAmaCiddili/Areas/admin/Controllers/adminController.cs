using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RestorantAmaCiddili.Areas.admin.Controllers
{
    [Area("admin")]
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult menuedit() 
        {
            ViewBag.ActivePage = "menuedit"; // Aktif sayfanın adı
            return View();
        }

    }
}
