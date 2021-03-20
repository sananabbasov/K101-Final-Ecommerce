using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class BlogViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
        public List <Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
    }
}
