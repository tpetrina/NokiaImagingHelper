using System;
using Nokia.Graphics.Imaging;

namespace FiltersHelper.Filters
{
    public class BlurFilter : BaseFilter
    {
        public BlurFilter(int blurLevel)
        {
            if (blurLevel <= 0)
                throw new ArgumentException("Value must be larger than 0", "blurLevel");

            Filter = FilterFactory.CreateBlurFilter(blurLevel);
        }
    }
}
