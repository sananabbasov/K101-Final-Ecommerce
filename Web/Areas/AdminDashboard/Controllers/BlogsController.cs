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
    public class BlogsController : Controller
    {
        private readonly EcommerceContext _context;
        private BlogService _blogService;

        public BlogsController(EcommerceContext context)
        {
            _blogService = new BlogService(context);
            _context = context;
        }

        // GET: AdminDashboard/Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.ToListAsync());
        }

        // GET: AdminDashboard/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: AdminDashboard/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminDashboard/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostName,PostUrl,PhotoUrl,Hit,UserID,UserName,PostDate,MyProperty,Description,ID,IsActive,IsDeleted,ModifiedOn")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: AdminDashboard/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: AdminDashboard/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, bool IsActive)
        {
            if (id == null) return View("Error");
            BlogViewModel vm = new BlogViewModel();

            vm.Blog = _blogService.GetBlogByID(id.Value);

            vm.Blog.IsActive = IsActive;


            _context.Update(vm.Blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("index","home");
        }

        // GET: AdminDashboard/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: AdminDashboard/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.ID == id);
        }
    }
}
