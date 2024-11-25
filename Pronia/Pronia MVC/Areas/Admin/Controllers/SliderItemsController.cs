using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pronia_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderItemsController : Controller
    {
        readonly ProniaDBContext _context;
        public SliderItemsController(ProniaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<SliderItem> sliderItems = _context.SliderItems.ToList();
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
            _context.SliderItems.Add(sliderItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            SliderItem deletedItem = _context.SliderItems.Find(Id);
            if (deletedItem == null)
            {
                return NotFound("Something went wrong");
            }
            _context.Remove(deletedItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            SliderItem sliderItem = _context.SliderItems.Find(Id);
            if (sliderItem == null)
            {
                return NotFound("Something went wrong");
            }

            return View(sliderItem);
        }

        [HttpPost]
        public IActionResult Edit(SliderItem sliderItem)
        {
            SliderItem currentItem = _context.SliderItems.Find(sliderItem.Id);
            if (currentItem == null)
            {
                return NotFound("Something went wrong");
            }
            if (!ModelState.IsValid) {
                return BadRequest("Something went wrong");
            }
            _context.SliderItems.Update(sliderItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
