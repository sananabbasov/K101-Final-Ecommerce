using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;

namespace Web.Areas.AdminDashboard.Controllers
{
    [Area("AdminDashboard")]
    public class CategoriesController : Controller
    {
        private readonly EcommerceContext _context;

        public CategoriesController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: AdminDashboard/Categories
        public async Task<IActionResult> Index()
        {
            var ecommerceContext = _context.Categories.Include(c => c.ParentCategory).Include(c => c.Picture);
            return View(await ecommerceContext.ToListAsync());
        }

        // GET: AdminDashboard/Categories/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var category = await _context.Categories
        //        .Include(c => c.ParentCategory)
        //        .Include(c => c.Picture)
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(category);
        //}

        // GET: AdminDashboard/Categories/Create
        public IActionResult Create()
        {
            ViewData["ParentCategoryID"] = new SelectList(_context.Categories, "ID", "Name");
            ViewData["PictureID"] = new SelectList(_context.Pictures, "ID", "ID");
            return View();
        }

        // POST: AdminDashboard/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParentCategoryID,Name,Description,PictureID,isFeatured,ID,IsActive,IsDeleted,ModifiedOn")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                category.IsActive = true;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentCategoryID"] = new SelectList(_context.Categories, "ID", "ID", category.ParentCategoryID);
            ViewData["PictureID"] = new SelectList(_context.Pictures, "ID", "ID", category.PictureID);
            return View(category);
        }

        // GET: AdminDashboard/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            ViewData["ParentCategoryID"] = new SelectList(_context.Categories, "ID", "Name", category.ParentCategoryID);
            ViewData["PictureID"] = new SelectList(_context.Pictures, "ID", "ID", category.PictureID);
            return View(category);
        }

        //POST: AdminDashboard/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParentCategoryID,Name,Description,PictureID,isFeatured,ID,IsActive,IsDeleted,ModifiedOn")] Category category)
        {
            if (id != category.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.ID))
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
            ViewData["ParentCategoryID"] = new SelectList(_context.Categories, "ID", "ID", category.ParentCategoryID);
            ViewData["PictureID"] = new SelectList(_context.Pictures, "ID", "ID", category.PictureID);
            return View(category);
        }

        // GET: AdminDashboard/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.ParentCategory)
                .Include(c => c.Picture)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: AdminDashboard/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            category.IsActive = false;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.ID == id);
        }
    }
}
