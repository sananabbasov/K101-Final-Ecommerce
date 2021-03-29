using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Product:BaseEntity
    {
        [Display(Name = "Kateqoriya")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [StringLength(100, ErrorMessage = "Məhsul adı minimum 3 maksimum 100 simvol olmalıdır.", MinimumLength = 3)]
        [Required(ErrorMessage = "Məhsul adını daxil edin.")]
        [Display(Name = "Məhsul adı")]
        public string ProductName { get; set; }
        [Display(Name = "Məhsul haqqında")]
        public string Description { get; set; }
        public string Seller { get; set; }
        [Display(Name = "Satıcının nömrəsi")]
        [Required(ErrorMessage = "Mobil nömrə daxil edin. Nümunə : 055 xxx xx xx")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Daxil olunan nömrə doğru formatda deyil. Nümunə : 055 xxx xx xx")]
        public string Number { get; set; }
        [Display(Name = "Nəşriyyat")]
        public string Publishing { get; set; }
        [Display(Name = "Müəllif")]
        [Required(ErrorMessage = "Müəllif adını daxil edin.")]
        public string Author { get; set; }
        public string PhotoURL { get; set; }
        [Display(Name = "Səhifə sayı")]
        [Required(ErrorMessage = "Səhifə sayını daxil edin")]
        public int Pages { get; set; }
        [Display(Name = "Qiymət")]
        [Required(ErrorMessage = "Qiyməti daxil edin.")]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Cost { get; set; }
        public bool isFeatured { get; set; }
        public int ThumbnailPictureID { get; set; }

        public string SKU { get; set; }
        public string Tags { get; set; }
        public string Barcode { get; set; }
        public string Supplier { get; set; }
        public int Hit { get; set; }

        public virtual List<ProductPicture> ProductPictures { get; set; }
    }
}
