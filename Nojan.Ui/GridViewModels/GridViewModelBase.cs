using System.ComponentModel;

namespace Nojan.Ui.GridViewModels
{
    public abstract class GridViewModelBase<TId>
    {
        [DisplayName("ردیف")]
        public int RowNumber { get; set; }
        public TId Id { get; set; }
    }
}
