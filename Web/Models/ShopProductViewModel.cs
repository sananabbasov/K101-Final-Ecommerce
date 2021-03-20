using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helper;

namespace Web.Models
{
    public class ShopProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public int? Category { get; set; }
        public string Search { get; set; }
        public int SortBya { get; set; }
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }

        public Pager Pager { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
    }
}
