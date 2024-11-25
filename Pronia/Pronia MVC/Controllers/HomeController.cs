using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pronia_MVC.Controllers
{
    public class HomeController : Controller
    {
        readonly ProniaDBContext _context;
        public HomeController(ProniaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<SliderItem> sliderItems = _context.SliderItems.ToList();
            return View(sliderItems);
        }
    }
}
