using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

namespace Web.Areas.User.Controllers
{
    [Area("User")]
    public class BlogsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly UserManager<K101User> _userManager;

        public BlogsController(EcommerceContext context, IWebHostEnvironment appEnvironment, UserManager<K101User> userManager)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
        }

        // GET: User/Blogs
        public async Task<IActionResult> Index()
        {
            ViewBag.userId = _userManager.GetUserId(HttpContext.User);
            return View(await _context.Blogs.ToListAsync());
        }

        // GET: User/Blogs/Details/5
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

        // GET: User/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostName,PostUrl,PhotoUrl,Hit,UserID,UserName,PostDate,MyProperty,ID,IsActive,IsDeleted,ModifiedOn,Description")] Blog blog, IFormFile PhotoUrl)
        {
            if (ModelState.IsValid)
            {
                string path = "/Uploads/" + Guid.NewGuid() + PhotoUrl.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await PhotoUrl.CopyToAsync(fileStream);
                }
                blog.UserID = _userManager.GetUserId(HttpContext.User);
                blog.UserName = _userManager.GetUserName(HttpContext.User);
                blog.PhotoUrl = path;
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: User/Blogs/Edit/5
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

        // POST: User/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostName,PostUrl,PhotoUrl,Hit,UserID,UserName,PostDate,MyProperty,ID,IsActive,IsDeleted,ModifiedOn,Description")] Blog blog, IFormFile PhotoUrl, string EditPhoto)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            string userName = _userManager.GetUserName(HttpContext.User);

            if (id != blog.ID)
            {
                return NotFound();
            }
            if (PhotoUrl == null)
            {
                blog.PhotoUrl = EditPhoto;
                
            }
            else
            {
                string path = "/Uploads/" + Guid.NewGuid() + PhotoUrl.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    Path.Combine(Directory.GetCurrentDirectory(), "Uploads", path);
                    await PhotoUrl.CopyToAsync(fileStream);
                }
                blog.PhotoUrl = path.Remove(0, 8);
            }
            if (ModelState.IsValid)
            {
                blog.UserID = userId;
                blog.UserName = userName;
                try
                {            
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.ID))
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
            return View(blog);
        }

        // GET: User/Blogs/Delete/5
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

        // POST: User/Blogs/Delete/5
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
