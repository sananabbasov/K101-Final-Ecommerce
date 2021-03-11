using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        private EcommerceContext _context;
        public CategoryService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category GetProductByID(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
