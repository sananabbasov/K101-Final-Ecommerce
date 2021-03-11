using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private ProductService _productService;
        private CategoryService _categoryService;
        public ProductsController(ILogger<ProductsController> logger, EcommerceContext context)
        {
            _productService = new ProductService(context);
            _categoryService = new CategoryService(context);
            _logger = logger;
        }
        public IActionResult Index(int? id, string search, int? sortBy, int? pageNo)
        {
            pageNo = pageNo.HasValue ? pageNo.Value : 1;
            sortBy = sortBy.HasValue ? sortBy.Value : 1;
            id = id.HasValue ? id.Value : 0;
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SerachProduct(id, search, sortBy, pageNo.Value),
                Categories = _categoryService.GetCategories(),
                PageNo = pageNo.Value,
                SortBya = sortBy.Value,
                Search = search,
                Category = id.Value
            };
            return View(vm);
        }

        public IActionResult SearchProduct(int? id, string search, int? sortBy, int? pageNo)
        {
            pageNo = pageNo.HasValue ? pageNo.Value : 1;
            sortBy = sortBy.HasValue ? sortBy.Value : 1;
            id = id.HasValue ? id.Value : 0;
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.SerachProduct(id, search, sortBy, pageNo.Value),
                Categories = _categoryService.GetCategories(),
                PageNo = pageNo.Value,
                SortBya = sortBy.Value,
                Search = search,
                Category = id.Value

            };
            return PartialView("ProductPartial",vm);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return View("Error");
            ProductViewModel vm = new ProductViewModel();
            vm.Product = _productService.GetProductByID(id.Value);
            return View(vm);
        }
    }
}
