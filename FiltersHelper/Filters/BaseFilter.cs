using System;
using Nokia.Graphics.Imaging;

namespace FiltersHelper.Filters
{
    /// <summary>
    /// You cannot change filter's parameters since that means removing the
    /// filter from the session and bringing it back.
    /// </summary>
    public abstract class BaseFilter : IFilter
    {
        public IFilter Filter { get; protected set; }

        public void Apply(IEditingSession editingSession)
        {
            throw new NotImplementedException();
        }

        public void Undo(IEditingSession editingSession)
        {
            throw new NotImplementedException();
        }
    }
}
