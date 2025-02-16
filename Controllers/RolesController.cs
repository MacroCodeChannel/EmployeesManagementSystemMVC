using EmployeesManagement.Data;
using EmployeesManagement.Models;
using EmployeesManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EmployeesManagement.Controllers
{
    public class RolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> rolemanager, SignInManager<ApplicationUser> signInManager)
        {
            _rolemanager = rolemanager;

            _signInManager = signInManager;

            _userManager = userManager;

            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            var roles = await _context.Roles.ToListAsync();
            return View(roles);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(RolesViewModel model)
        {
            try
            {

                IdentityRole role = new IdentityRole();
                role.Name = model.RoleName;

                var result = await _rolemanager.CreateAsync(role);
                if (result.Succeeded)
                {
                    TempData["Success"] = "Role Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = "Error Creating Role";
                    return View(model);
                }

            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error Creating Role" + ex.Message;
                return View(model);
            }
        }

        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            var role = new RolesViewModel();
            var result = await _rolemanager.FindByIdAsync(id);
            role.RoleName = result.Name;
            role.Id = result.Id;

            return View(role);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(string id, RolesViewModel model)
        {
            var checkifexist = await _rolemanager.RoleExistsAsync(model.RoleName);
            if (!checkifexist)
            {

                var result = await _rolemanager.FindByIdAsync(id);
                result.Name = model.RoleName;

                var finalresult = await _rolemanager.UpdateAsync(result);
                if (finalresult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }

            return View(model);
        }
    }
}
