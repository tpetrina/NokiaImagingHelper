using System;
using System.Diagnostics;
using FiltersHelper.Parameters;
using FiltersHelper.ParametersInfo;
using Nokia.Graphics.Imaging;

namespace FiltersHelper
{
    public class FilterInfo
    {
        private Func<IFilterParameters, IFilter> _creator;

        public string Name { get; private set; }
        public IFilterParametersInfo FilterParameters { get; private set; }

        public IFilter Create()
        {
            Debug.Assert(!FilterParameters.AcceptsParameters);
            return _creator(null);
        }

        public IFilter Create(IFilterParameters parameters)
        {
            Debug.Assert(FilterParameters.AcceptsParameters);
            return _creator(parameters);
        }

        #region Internal builders

        internal static FilterInfo CreateInfo(string name, Func<IFilter> filterCreator)
        {
            return new FilterInfo
                {
                    Name = name,
                    FilterParameters = FilterParametersInfo.None,
                    _creator = _ => filterCreator()
                };
        }

        internal static FilterInfo CreateInfo(string name, Func<int, IFilter> filterCreator)
        {
            return new FilterInfo
            {
                Name = name,
                FilterParameters = FilterParametersInfo.None,
                _creator = (IFilterParameters parameters) =>
                    {
                        var intParameters = parameters as IntParameters;
                        return filterCreator(intParameters.Value);
                    }
            };
        }

        #endregion
    }
}
