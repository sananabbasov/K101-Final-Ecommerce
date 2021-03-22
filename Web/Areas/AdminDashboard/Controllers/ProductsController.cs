using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Web.Models;
using Services;

namespace Web.Areas.AdminDashboard.Controllers
{
    [Area("AdminDashboard")]
    public class ProductsController : Controller
    {
        private readonly EcommerceContext _context;
        private ProductService _productService;

        public ProductsController(EcommerceContext context)
        {
            _productService = new ProductService(context);
            _context = context;
        }

        // GET: AdminDashboard/Products
        public async Task<IActionResult> Index()
        {
            var ecommerceContext = _context.Products.Include(p => p.Category);
            return View(await ecommerceContext.ToListAsync());
        }

        // GET: AdminDashboard/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: AdminDashboard/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "ID");
            return View();
        }

        // POST: AdminDashboard/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,ProductName,Description,Seller,Number,Publishing,Author,PhotoURL,Pages,Price,Discount,Cost,isFeatured,ThumbnailPictureID,SKU,Tags,Barcode,Supplier,Hit,ID,IsActive,IsDeleted,ModifiedOn")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "ID", product.CategoryID);
            return View(product);
        }

        // GET: AdminDashboard/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "ID", product.CategoryID);
            return View(product);
        }

        // POST: AdminDashboard/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, bool IsDeleted, bool IsActive)
        {
            if (id == null) return View("Error");

            ProductViewModel product = new ProductViewModel();

            product.Product = _productService.GetProductByID(id.Value);


            product.Product.IsDeleted = IsDeleted;
            product.Product.IsActive = IsActive;

            _context.Update(product.Product);
            await _context.SaveChangesAsync();
            return RedirectToAction("index", "products");
        }

        // GET: AdminDashboard/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: AdminDashboard/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
