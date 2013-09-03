using System;
using Nokia.Graphics.Imaging;

namespace FiltersHelper.Filters
{
    public class BrightnessFilter : BaseFilter
    {
        public double Brightness { get; set; }

        public BrightnessFilter()
        {
            Filter = FilterFactory.CreateBrightnessFilter(0);
        }

        public BrightnessFilter(double brightness)
        {
            if (brightness < -1 || brightness > 10)
                throw new ArgumentException("Value must be in range [-1.0, 1.0]", "brightness");

            Filter = FilterFactory.CreateBrightnessFilter(brightness);
        }
    }
}
