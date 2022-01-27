using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselSDCard
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Download/download1.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Download/download2.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Download/download3.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Download/download4.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Download/download5.JPG"));
        }

        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
