using FiltersHelper.Parameters;

namespace FiltersHelper.ParametersInfo
{
    public class FilterParametersInfo : IFilterParametersInfo
    {
        private static FilterParametersInfo _none;

        public static FilterParametersInfo None
        {
            get
            {
                return _none = _none ?? new FilterParametersInfo
                    {
                        AcceptsParameters = false
                    };
            }
        }

        public bool AcceptsParameters { get; protected set; }

        public IFilterParameters Wrap(int value)
        {
            return new IntParameters
            {
                Value = value
            };
        }
    }
}