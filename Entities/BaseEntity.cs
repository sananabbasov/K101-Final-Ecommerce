using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Aktivləşdir")]
        public bool IsActive { get; set; }
        [Display(Name = "Sil")]
        public bool IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
