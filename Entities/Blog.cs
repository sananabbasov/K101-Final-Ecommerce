using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog : BaseEntity
    {
        [StringLength(100, ErrorMessage = "Başlıq minimum 3 maksimum 100 simvol olmalıdır.", MinimumLength = 3)]
        [Required(ErrorMessage = "Başlıq daxil edin.")]
        [Display(Name = "Başlıq")]
        public string PostName { get; set; }
        public string PostUrl { get; set; }
        [Display(Name = "Şəkil")]
        public string PhotoUrl { get; set; }
        public int Hit { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public DateTime PostDate { get; set; }
        public int MyProperty { get; set; }
        [StringLength(10000, ErrorMessage = "Məqalə minimum 1000 maksimum 10000 simvol olmalıdır.", MinimumLength = 1000)]
        [Required(ErrorMessage = "Məqalənizi daxil edin.")]
        [Display(Name = "Məqalə")]
        public string Description { get; set; }
    }
}
