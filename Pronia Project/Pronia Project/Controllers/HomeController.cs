using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_Project.DAL;
using Pronia_Project.Models;
using Pronia_Project.ViewModels.Home;
using System;

namespace Pronia_Project.Controllers
{
    public class HomeController : Controller
    {
        readonly ProniaDBContext _context;
        public HomeController(ProniaDBContext proniaDBContext)
        {
            _context = proniaDBContext;
        }
        public IActionResult Index()
        {
            //SliderItem item = new SliderItem()
            //{
            //    Title = "New Plant",
            //    ShortDesc = "Pronia, With 100% Natural, Organic & Plant Shop.",
            //    Offer = 65,
            //    İmagePath = "1-1-524x617.png"
            //};
            //SliderItem item1 = new SliderItem()
            //{
            //    Title = "New Plant",
            //    ShortDesc = "Pronia, With 100% Natural, Organic & Plant Shop.",
            //    Offer = 65,
            //    İmagePath = "1-1-524x617.png"
            //};
            //proniaDBContext.SliderItems.Add(item1);
            //proniaDBContext.SaveChanges();

            IEnumerable<SliderItem> sliderItems = _context.SliderItems.ToList();
            HomeVM homeVM = new HomeVM()
            {
                SliderItems = sliderItems
            };

            return View(homeVM);
        }
    }
}
