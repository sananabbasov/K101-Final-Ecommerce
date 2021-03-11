using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.AdminDashboard.ViewModel;

namespace Web.Areas.AdminDashboard.Controllers
{
    [Area("admindashboard")]
    //[Authorize(Roles = "Admin")]
    public class AdminUserController : Controller
    {
        public UserManager<K101User> _userManager { get; set; }
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminUserController(UserManager<K101User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

        public async Task<IActionResult> AddRole(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            K101User user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var userRoles = (await _userManager.GetRolesAsync(user)).ToList();
            var allRoles = _roleManager.Roles.Select(r => r.Name).ToList();
            AddRoleUserVM vm = new AddRoleUserVM()
            {
                K101User = user,
                Roles = allRoles.Except(userRoles)
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(string id, string role)
        {
            if (id == null)
            {
                return NotFound();
            }
            K101User user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var result = await _userManager.AddToRoleAsync(user, role);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index), new { id = id });
            }
            return RedirectToAction(nameof(AddRole), new { id = id });
        }
    }
}
