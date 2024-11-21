using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_Project.DAL.Contexts;
using Pronia_Project.Models;
using System;

namespace Pronia_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProniaDBContext proniaDBContext = new();
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

            List<SliderItem> sliderItems = proniaDBContext.SliderItems.FromSql($"SELECT * FROM SliderItems").ToList();

            return View(sliderItems);
        }
    }
}
