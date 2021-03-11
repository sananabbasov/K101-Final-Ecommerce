using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductService _productService;
        private AdvertisementService _advertisementService;
        private CategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger, EcommerceContext context)
        {
            _productService = new ProductService(context);
            _logger = logger;
            _advertisementService = new AdvertisementService(context);
            _categoryService = new CategoryService(context);
        }

        public IActionResult Index(int? pageNo)
        {
            pageNo = pageNo.HasValue ? pageNo.Value : 1;

            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.GetProducts(pageNo.Value),
                Categories = _categoryService.GetCategories(),
                Advertisements = _advertisementService.GetAdvertisements()
            };


            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
