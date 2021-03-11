using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product:BaseEntity
    {
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Seller { get; set; }
        public int Number { get; set; }
        public string Publishing { get; set; }
        public string Author { get; set; }
        public string PhotoURL { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Cost { get; set; }
        public bool isFeatured { get; set; }
        public int ThumbnailPictureID { get; set; }

        public string SKU { get; set; }
        public string Tags { get; set; }
        public string Barcode { get; set; }
        public string Supplier { get; set; }

        public virtual List<ProductPicture> ProductPictures { get; set; }
    }
}
