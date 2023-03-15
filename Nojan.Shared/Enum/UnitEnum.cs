using System.ComponentModel.DataAnnotations;

namespace Nojan.Shared.Enum;

public enum UnitEnum
{
    [Display(Name = "عدد")]
    Number,
    [Display(Name = "متر")]
    Meter,
    [Display(Name = "ساعت")]
    Hour

}
