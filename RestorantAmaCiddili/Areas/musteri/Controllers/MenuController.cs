using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestorantAmaCiddili.Data;
using RestorantAmaCiddili.Models;
using System.Linq;

namespace RestorantAmaCiddili.Areas.musteri.Controllers
{
    [Area("musteri")]
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly ApplicationDbContext _db;

        public MenuController(ILogger<MenuController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            //var Menu = _db.Foods.Where(i => i.Activeness).ToList();
            //var Categories = _db.Categories.ToList();
            var model = new FoodCategoryViewModel
            {
                Foods = _db.Foods.Where(i => i.Activeness).ToList(),
                Categories = _db.Categories.ToList()
            };
            return View(model);
        }
    }
}
