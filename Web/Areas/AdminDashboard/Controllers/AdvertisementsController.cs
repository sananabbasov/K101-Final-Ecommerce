using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Web.Areas.AdminDashboard.Controllers
{
    [Area("AdminDashboard")]
    public class AdvertisementsController : Controller
    {
        private readonly EcommerceContext _context;
        private IWebHostEnvironment Environment;
        public AdvertisementsController(EcommerceContext context, IWebHostEnvironment _environment)
        {
            _context = context;
            Environment = _environment;
        }

        // GET: AdminDashboard/Advertisements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Advertisementies.ToListAsync());
        }

        // GET: AdminDashboard/Advertisements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisementies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (advertisement == null)
            {
                return NotFound();
            }

            return View(advertisement);
        }

        // GET: AdminDashboard/Advertisements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminDashboard/Advertisements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Url,Click,EndTime,ID,IsActive,IsDeleted,ModifiedOn,PhotoURL")] Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                var pictures = Request.Form.Files;
                for (int i = 0; i < pictures.Count; i++)
                {
                    var picture = pictures[i];


                    var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                    string uploadsFolder = Path.Combine(Environment.WebRootPath, "uploads");
                    string filePath = Path.Combine(uploadsFolder, fileName);
                    advertisement.PhotoURL = fileName;
                    advertisement.Click = 0;
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        picture.CopyTo(fileStream);
                    }
                    _context.AddRange(advertisement);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(advertisement);
        }

        // GET: AdminDashboard/Advertisements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisementies.FindAsync(id);
            if (advertisement == null)
            {
                return NotFound();
            }
            return View(advertisement);
        }

        // POST: AdminDashboard/Advertisements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Url,Click,EndTime,ID,IsActive,IsDeleted,ModifiedOn")] Advertisement advertisement)
        {
            if (id != advertisement.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advertisement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvertisementExists(advertisement.ID))
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
            return View(advertisement);
        }

        // GET: AdminDashboard/Advertisements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisementies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (advertisement == null)
            {
                return NotFound();
            }

            return View(advertisement);
        }

        // POST: AdminDashboard/Advertisements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advertisement = await _context.Advertisementies.FindAsync(id);
            _context.Advertisementies.Remove(advertisement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvertisementExists(int id)
        {
            return _context.Advertisementies.Any(e => e.ID == id);
        }
    }
}
