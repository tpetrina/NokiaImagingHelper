using System.Collections.Generic;
using Nokia.Graphics.Imaging;

namespace FiltersHelper
{
    public static class FiltersLibrary
    {
        private static List<FilterInfo> _allFilters;

        public static List<FilterInfo> GetAllFilters()
        {
            if (_allFilters == null)
            {
                _allFilters = new List<FilterInfo>
                    {
                        FilterInfo.CreateInfo("Antique",FilterFactory.CreateAntiqueFilter),
                        FilterInfo.CreateInfo("Blur", FilterFactory.CreateBlurFilter)
                    };
            }

            return _allFilters;
        }
    }
}
