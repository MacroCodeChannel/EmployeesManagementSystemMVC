using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeesManagement.Data;
using EmployeesManagement.Models;
using System.Security.Claims;
using EmployeesManagement.Data.Migrations;

namespace EmployeesManagement.Controllers
{
    public class WorkFlowUserGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkFlowUserGroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkFlowUserGroups
        public async Task<IActionResult> Index()
        {
           var groups = await _context.WorkFlowUserGroups
                .Include(x=>x.Department)
                .Include(x=>x.DocumentType)
                .ToListAsync();

            return View(groups);
        }

        // GET: WorkFlowUserGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workFlowUserGroup = await _context.WorkFlowUserGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workFlowUserGroup == null)
            {
                return NotFound();
            }

            return View(workFlowUserGroup);
        }

        // GET: WorkFlowUserGroups/Create
        public IActionResult Create()
        {
            ViewData["DocumentTypeId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(y => y.SystemCode.Code == "DocumentTypes"), "Id", "Description");
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: WorkFlowUserGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( WorkFlowUserGroup workFlowUserGroup)
        {

            try
            {

                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Add(workFlowUserGroup);
                await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "WorkFlowUserGroup created successfully";

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred while creating WorkFlowUserGroup" +ex.Message;
                ModelState.AddModelError("", ex.Message);
                return View(workFlowUserGroup);
            }

            ViewData["DocumentTypeId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(y => y.SystemCode.Code == "DocumentTypes"), "Id", "Description", workFlowUserGroup.DocumentTypeId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", workFlowUserGroup.DepartmentId);

        }

        // GET: WorkFlowUserGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workFlowUserGroup = await _context.WorkFlowUserGroups.FindAsync(id);
            if (workFlowUserGroup == null)
            {
                return NotFound();
            }

            ViewData["DocumentTypeId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(y => y.SystemCode.Code == "DocumentTypes"), "Id", "Description", workFlowUserGroup.DocumentTypeId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", workFlowUserGroup.DepartmentId);

            return View(workFlowUserGroup);
        }

        // POST: WorkFlowUserGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,WorkFlowUserGroup workFlowUserGroup)
        {
            if (id != workFlowUserGroup.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Department");
            ModelState.Remove("DocumentType");
            if (ModelState.IsValid)
            {
                try
                {
                    var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _context.Update(workFlowUserGroup);
                    await _context.SaveChangesAsync(Userid);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkFlowUserGroupExists(workFlowUserGroup.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                ViewData["DocumentTypeId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(y => y.SystemCode.Code == "DocumentTypes"), "Id", "Description", workFlowUserGroup.DocumentTypeId);
                ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", workFlowUserGroup.DepartmentId);
                return RedirectToAction(nameof(Index));
            }
            return View(workFlowUserGroup);
        }

        // GET: WorkFlowUserGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workFlowUserGroup = await _context.WorkFlowUserGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workFlowUserGroup == null)
            {
                return NotFound();
            }

            return View(workFlowUserGroup);
        }

        // POST: WorkFlowUserGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workFlowUserGroup = await _context.WorkFlowUserGroups.FindAsync(id);
            if (workFlowUserGroup != null)
            {
                _context.WorkFlowUserGroups.Remove(workFlowUserGroup);
            }

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _context.SaveChangesAsync(userid);
            return RedirectToAction(nameof(Index));
        }

        private bool WorkFlowUserGroupExists(int id)
        {
            return _context.WorkFlowUserGroups.Any(e => e.Id == id);
        }
    }
}
