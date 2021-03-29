using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class UserProductsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly UserManager<K101User> _userManager;
        private readonly IWebHostEnvironment _appEnvironment;


        public UserProductsController(EcommerceContext context, UserManager<K101User> userManager, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _appEnvironment = appEnvironment;
        }

        // GET: User/UserProducts
        public async Task<IActionResult> Index()
        {

            ViewBag.userId = _userManager.GetUserId(HttpContext.User);

            var ecommerceContext = _context.Products.Include(p => p.Category);
            return View(await ecommerceContext.ToListAsync());
        }

        // GET: User/UserProducts/Details/5
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

        // GET: User/UserProducts/Create
        public IActionResult Create()
        {
            ViewBag.userId = _userManager.GetUserId(HttpContext.User);
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name");
            return View();
        }

        // POST: User/UserProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID, ProductName, Description, Seller, Number, Publishing, Author, Pages, Price, Discount, Cost, isFeatured, ThumbnailPictureID, SKU, Tags, Barcode, Supplier, ID, IsActive, IsDeleted, ModifiedOn")] Product product)
        {
            string userId = _userManager.GetUserId(HttpContext.User);

            if (userId != product.Seller)
            {
                return RedirectToAction(nameof(Create));
            }
            

            if (ModelState.IsValid)
            {
                product.Supplier = _userManager.GetUserName(HttpContext.User);
                product.Seller = userId;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: User/UserProducts/Edit/5
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // POST: User/UserProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,ProductName,Description,Seller,Number,Publishing,Author,Pages,Price,Discount,Cost,isFeatured,ThumbnailPictureID,SKU,Tags,Barcode,Supplier,ID,IsActive,IsDeleted,ModifiedOn")] Product product, IFormFile Tags, string EditPhoto)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            if (id != product.ID)
            {
                return NotFound();
            }

            if (Tags == null)
            {
                product.Tags = EditPhoto;
            }
            else
            {
                string path = "/Uploads/" + Guid.NewGuid() + Tags.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    Path.Combine(Directory.GetCurrentDirectory(), "Uploads", path);
                    await Tags.CopyToAsync(fileStream);
                }
                product.Tags = path.Remove(0, 8);
            }

            if (ModelState.IsValid)
            {
                
                
                product.Seller = userId;
                
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: User/UserProducts/Delete/5
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

        // POST: User/UserProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
