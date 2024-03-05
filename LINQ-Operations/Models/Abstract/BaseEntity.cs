using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Models.Abstract
{
    public enum Status 
    {
        [Display(Name = "Aktif")]
        Active = 1,
        [Display(Name = "Güncellenmiş")]
        Modified = 2,
        [Display(Name = "Pasif")]
        Passive = 3 
    }
    public abstract class BaseEntity<T>
    {

        public abstract T Id { get; set; }
        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }

        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
