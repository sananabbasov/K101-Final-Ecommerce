using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Areas.AdminDashboard.Controllers
{
    [Area("admindashboard")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductService _productService;
        private BlogService _blogService;

        public HomeController(ILogger<HomeController> logger, EcommerceContext context)
        {
            _productService = new ProductService(context);
            _blogService = new BlogService(context);
            _logger = logger;
        }

        public IActionResult Index()
        {
            ShopProductViewModel vm = new ShopProductViewModel()
            {
                Products = _productService.GetAllProducts(),
                Blogs = _blogService.GetAllProducts()
                

            };
            return View(vm);
        }
    }
}
