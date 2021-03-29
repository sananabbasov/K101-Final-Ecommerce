using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helper;
using Web.Models;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly EcommerceContext _context;
        private readonly ILogger<ProductsController> _logger;
        private ProductService _productService;
        private CategoryService _categoryService;
        public ProductsController(ILogger<ProductsController> logger, EcommerceContext context, IHttpContextAccessor httpContextAccessor)
        {
            _productService = new ProductService(context);
            _categoryService = new CategoryService(context);
            _context = context;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index(int? id, string search, int? sortBy, int? pageNo, int? recordSize)
        {
            recordSize = recordSize.HasValue ? recordSize.Value:10;
            sortBy = sortBy.HasValue ? sortBy.Value : 1;
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SerachProduct(id, search, sortBy, pageNo, recordSize.Value, out int count),
                Categories = _categoryService.GetCategories(),
                PageNo = pageNo,
                SortBya = sortBy.Value,
                Search = search,
                Category = id,
                PageSize = recordSize.Value
            };
            vm.Pager = new Pager(count, pageNo, recordSize.Value);
            return View(vm);
        }

        public IActionResult SearchProduct(int? id, string search, int? sortBy, int? pageNo, int recordSize=5)
        {
            pageNo = pageNo.HasValue ? pageNo.Value : 1;
            sortBy = sortBy.HasValue ? sortBy.Value : 1;
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SerachProduct(id, search, sortBy, pageNo.Value, recordSize, out int count),
                Categories = _categoryService.GetCategories(),
                PageNo = pageNo.Value,
                SortBya = sortBy.Value,
                Search = search,
                Category = id

            };
            return PartialView("ProductPartial",vm);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            
            if (id == null) return View("Error");
            ProductViewModel vm = new ProductViewModel();
            string key = Convert.ToString(id);
            string value = "K101";


            
            vm.Product = _productService.GetProductByID(id.Value);



            var cookieValue = Request.Cookies[key];

            if (cookieValue == null)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(key, value, cookieOptions);
                if (vm.Product.Hit != null)
                {
                    vm.Product.Hit += 1;
                }
                else
                {
                    vm.Product.Hit = 1;
                }
            }

            
                
            

            


            _context.Update(vm.Product);
             await _context.SaveChangesAsync();
            return View(vm);
        }
    }
}
