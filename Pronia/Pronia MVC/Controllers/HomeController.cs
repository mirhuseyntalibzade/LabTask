using BusinessLayer.Services.Abstractions;
using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pronia_MVC.Controllers
{
    public class HomeController : Controller
    {
        readonly ISliderItemsService _sliderItemService;
        public HomeController(ISliderItemsService sliderItemsService)
        {
            _sliderItemService = sliderItemsService;
        }
        public IActionResult Index()
        {
            IEnumerable<SliderItem> sliderItems = _sliderItemService.GetAllSliderItems();
            return View(sliderItems);
        }
    }
}
