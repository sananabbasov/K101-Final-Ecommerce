using DataAccess;
using Microsoft.AspNetCore.Http;
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
    public class BlogController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly EcommerceContext _context;
        private readonly ILogger<BlogController> _logger;
        private ProductService _productService;
        private CategoryService _categoryService;
        private BlogService _blogService;
        public BlogController(ILogger<BlogController> logger, EcommerceContext context, IHttpContextAccessor httpContextAccessor)
        {
            _productService = new ProductService(context);
            _categoryService = new CategoryService(context);
            _context = context;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _blogService = new BlogService(context);
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            BlogViewModel vm = new BlogViewModel()
            {
                Blog = _blogService.GetBlogByID(id.Value),
                Products = _productService.GetProductsByView(),
                Categories = _categoryService.GetCategories()

            };
            if (id == null) return View("Error");
            string key = Convert.ToString(id);
            string value = "K101";


            var cookieValue = Request.Cookies[key];

            if (cookieValue == null)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(key, value, cookieOptions);
            
                    vm.Blog.Hit += 1;
                
            }


            _context.Update(vm.Blog);
            await _context.SaveChangesAsync();
            return View(vm);
        }
    }
}
