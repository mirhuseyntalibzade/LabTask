using BusinessLayer.Services.Abstractions;
using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pronia_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderItemsController : Controller
    {
        readonly ISliderItemsService _sliderItemService;
        public SliderItemsController(ISliderItemsService sliderItemsService)
        {
            _sliderItemService = sliderItemsService;
        }
        public IActionResult Index()
        {
            IEnumerable<SliderItem> sliderItems = _sliderItemService.GetAllSliderItems();
            return View(sliderItems);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SliderItem sliderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }
            _sliderItemService.CreateSliderItem(sliderItem);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            SliderItem deletedItem = _sliderItemService.FindSliderItem(Id);
            if (deletedItem == null)
            {
                return NotFound("Something went wrong");
            }
            _sliderItemService.DeleteSliderItem(deletedItem);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            SliderItem sliderItem = _sliderItemService.FindSliderItem(Id);
            if (sliderItem == null)
            {
                return NotFound("Something went wrong");
            }

            return View(sliderItem);
        }

        [HttpPost]
        public IActionResult Edit(SliderItem sliderItem)
        {
            SliderItem currentItem= _sliderItemService.FindSliderItem(sliderItem.Id);
            if (currentItem == null)
            {
                return NotFound("Something went wrong");
            }
            if (!ModelState.IsValid) {
                return BadRequest("Something went wrong");
            }
            _sliderItemService.EditSliderItem(sliderItem);
            return RedirectToAction("Index");
        }
    }
}
