using EmployeesManagement.Data;
using EmployeesManagement.Models;
using EmployeesManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;

namespace EmployeesManagement.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            var tasks = new ProfileViewModel();
            var roles = await _context.Roles.OrderBy(x => x.Name).ToListAsync();
            ViewBag.Roles = new SelectList(roles, "Id", "Name");

            var systemtasks = await _context.SystemProfiles
               .Include("Children.Children.Children")
               .OrderBy(x => x.Order)
               .ToListAsync();



            ViewBag.Tasks = new SelectList(systemtasks, "Id", "Name");

            return View(tasks);
        }
        public async Task<ActionResult> AssignRights(ProfileViewModel vm)
        {
            try
            {
                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var role = new RoleProfile
                {
                    TaskId = vm.TaskId,
                    RoleId = vm.RoleId,
                };
                _context.RoleProfiles.Add(role);
                await _context.SaveChangesAsync(Userid);
                TempData["Success"] = "Role Assigned Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error Assigning Role" + ex.Message;
                return View(vm);
            }
        }


        [HttpGet]
        public async Task<ActionResult> UserRights(string id)
        {
            var tasks = new ProfileViewModel();
            tasks.RoleId = id;
            tasks.Profiles = await _context.SystemProfiles
               .Include(s => s.Profile)
               .Include("Children.Children.Children")
               .OrderBy(x => x.Order)
               .ToListAsync();

            tasks.RolesRightsIds = await _context.RoleProfiles.Where(x => x.RoleId == id).Select(r => r.TaskId).ToListAsync();

            return View(tasks);
        }
        [HttpPost]
        public async Task<ActionResult> UserGroupRights(string id, ProfileViewModel vm)
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var allrights = await _context.RoleProfiles.Where(x => x.RoleId == id).ToListAsync();
            _context.RoleProfiles.RemoveRange(allrights);
            await _context.SaveChangesAsync(Userid);


            foreach (var taskId in vm.Ids.Distinct())
            {
                var role = new RoleProfile
                {
                    TaskId = taskId,
                    RoleId = id,
                };
                _context.RoleProfiles.Add(role);
                await _context.SaveChangesAsync(Userid);
            }
            return RedirectToAction("Index");
        }
    }
}