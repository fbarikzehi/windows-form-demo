using System;
using System.ComponentModel.DataAnnotations;

namespace Nojan.Data.Model
{
    public abstract class ModelBase<TId>
    {
        [Key]
        public TId Id { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateDateTime { get; set; } = null;
    }
}
