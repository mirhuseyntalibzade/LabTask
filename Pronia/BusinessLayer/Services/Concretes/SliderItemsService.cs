using BusinessLayer.Services.Abstractions;
using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Concretes
{
    public class SliderItemsService : ISliderItemsService
    {
        readonly ProniaDBContext _context;
        public SliderItemsService(ProniaDBContext context)
        {
            _context = context;
        }
        public IEnumerable<SliderItem> GetAllSliderItems()
        {
            IEnumerable<SliderItem> sliderItems = _context.SliderItems.ToList();
            return sliderItems;
        }

        public void CreateSliderItem(SliderItem sliderItem)
        {
            _context.SliderItems.Add(sliderItem);
            _context.SaveChanges();
        }

        public void DeleteSliderItem(SliderItem deletedItem)
        {
            _context.Remove(deletedItem);
            _context.SaveChanges();
        }

        public void EditSliderItem(SliderItem sliderItem)
        {
            _context.Update(sliderItem);
            _context.SaveChanges();
        }

        public SliderItem FindSliderItem(int Id)
        {
            SliderItem deletedItem = _context.SliderItems.Find(Id);
            return deletedItem;
        }

    }
}
