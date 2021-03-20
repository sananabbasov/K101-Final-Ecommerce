using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private EcommerceContext _context;
        public ProductService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts(int pageNo)
        {
            var products = _context.Products.AsQueryable();
            products = products.OrderByDescending(x => x.ID);

            return products.Skip((pageNo - 1) * 3).Take(10).ToList();
        }
        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();

            return products;
        }
        public List<Product> GetProductsByView()
        {
            var products = _context.Products.OrderByDescending(x=>x.Hit).Take(8).ToList();

            return products;
        }
        public Product GetProductByID(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> SerachProduct(int? id, string search, int? sortBy, int? pageNo, int? recordSize, out int count)
        {
            var products = _context.Products.AsQueryable();
            if (id.HasValue)
            {
                products = products.Where(x => x.CategoryID == id);
            }
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.ProductName.Contains(search));
            }
            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 2:
                        products = products.OrderByDescending(x => x.Price);
                        break;
                    case 3:
                        products = products.OrderBy(x => x.Price);
                        break;
                    default:
                        products = products.OrderByDescending(x => x.Price);

                        break;
                }
            }
            pageNo = pageNo ?? 1;
            var skipCount = (pageNo.Value - 1) * recordSize.Value;
            count = products.Count();
            return products.Skip(skipCount).Take(recordSize.Value).ToList();

        }
        public List<Product> ListProduct(int? pageNo, int? recordSize, out int count)
        {
            var products = _context.Products.AsQueryable();
            
            pageNo = pageNo ?? 1;
            var skipCount = (pageNo.Value - 1) * recordSize.Value;
            count = products.Count();
            return products.Skip(skipCount).Take(recordSize.Value).ToList();

        }

    }
}
