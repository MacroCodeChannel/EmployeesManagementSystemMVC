using EmployeesManagement.Data;
using EmployeesManagement.Models;
using EmployeesManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagement.Controllers
{

    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> rolemanager, SignInManager<ApplicationUser> signInManager)
        {
            _rolemanager = rolemanager;

            _signInManager = signInManager;

            _userManager = userManager;
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var users = await _context.Users.Include(x=>x.Role).ToListAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserViewModel model)
        {
            try
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = model.UserName;
                user.FirstName = model.FirstName;
                user.MiddleName = model.MiddleName;
                user.LastName = model.LastName;
                user.NationalId = model.NationalId;
                user.UserName = model.UserName;
                user.NormalizedUserName = model.UserName;
                user.Email = model.Email;
                user.EmailConfirmed = true;
                user.PhoneNumber = model.PhoneNumber;
                user.PhoneNumberConfirmed = true;
                user.CreatedOn = DateTime.Now;
                user.CreatedById = "Macro Code";
                user.RoleId = model.RoleId;
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    TempData["Success"] = "User created successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["Error"] = "User creation failed" + result.Errors;
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "User creation failed" + ex.Message;
                return View(model);
            }

            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name", model.RoleId);

        }
    }
}
