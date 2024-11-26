using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Abstractions
{
    public interface ISliderItemsService
    {
        public IEnumerable<SliderItem> GetAllSliderItems();
        public void CreateSliderItem(SliderItem sliderItem);
        public void DeleteSliderItem(SliderItem slider);
        public void EditSliderItem(SliderItem sliderItem);
        public SliderItem FindSliderItem(int Id);
    }
}
