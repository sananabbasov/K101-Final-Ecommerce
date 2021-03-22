using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BlogService
    {
        private EcommerceContext _context;
        public BlogService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Blog> GetAllProducts()
        {
            var products = _context.Blogs.ToList();

            return products;
        }
        public Blog GetBlogByID(int? id)
        {
            return _context.Blogs.Find(id);
        }


    }
}
