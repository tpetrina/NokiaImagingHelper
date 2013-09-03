using Nokia.Graphics.Imaging;

namespace FiltersHelper.Filters
{
    public class AntiqueFilter : BaseFilter
    {
        public AntiqueFilter()
        {
            Filter = FilterFactory.CreateAntiqueFilter();
        }
    }
}
