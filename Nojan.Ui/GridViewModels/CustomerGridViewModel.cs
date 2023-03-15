using System.ComponentModel;

namespace Nojan.Ui.GridViewModels
{
    public class CustomerGridViewModel: GridViewModelBase<int>
    {
        [DisplayName("نام و نام خانوادگی")]
        public string FullName { get; set; }
        [DisplayName("تلفن همراه")]
        public string Mobile { get; set; }
        [DisplayName("کد مشتری")]
        public int Code { get; set; }

    }
}
