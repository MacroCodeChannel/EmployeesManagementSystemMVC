using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeesManagement.Data;
using EmployeesManagement.Models;

namespace EmployeesManagement.Controllers
{
    public class LeaveAdjustmentEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeaveAdjustmentEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeaveAdjustmentEntries
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LeaveAdjustmentEntries.Include(l => l.AdjustmentType).Include(l => l.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LeaveAdjustmentEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAdjustmentEntry = await _context.LeaveAdjustmentEntries
                .Include(l => l.AdjustmentType)
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveAdjustmentEntry == null)
            {
                return NotFound();
            }

            return View(leaveAdjustmentEntry);
        }

        // GET: LeaveAdjustmentEntries/Create
        public IActionResult Create()
        {
            ViewData["AdjustmentTypeId"] = new SelectList(_context.SystemCodeDetails, "Id", "Description");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            return View();
        }

        // POST: LeaveAdjustmentEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LeavePeriod,EmployeeId,NoOfDays,LeaveAdjustmentDate,LeaveStartDate,LeaveEndDate,AdjustmentDescription,AdjustmentTypeId")] LeaveAdjustmentEntry leaveAdjustmentEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaveAdjustmentEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdjustmentTypeId"] = new SelectList(_context.SystemCodeDetails, "Id", "Id", leaveAdjustmentEntry.AdjustmentTypeId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", leaveAdjustmentEntry.EmployeeId);
            return View(leaveAdjustmentEntry);
        }

        // GET: LeaveAdjustmentEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAdjustmentEntry = await _context.LeaveAdjustmentEntries.FindAsync(id);
            if (leaveAdjustmentEntry == null)
            {
                return NotFound();
            }
            ViewData["AdjustmentTypeId"] = new SelectList(_context.SystemCodeDetails, "Id", "Id", leaveAdjustmentEntry.AdjustmentTypeId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", leaveAdjustmentEntry.EmployeeId);
            return View(leaveAdjustmentEntry);
        }

        // POST: LeaveAdjustmentEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LeavePeriod,EmployeeId,NoOfDays,LeaveAdjustmentDate,LeaveStartDate,LeaveEndDate,AdjustmentDescription,AdjustmentTypeId")] LeaveAdjustmentEntry leaveAdjustmentEntry)
        {
            if (id != leaveAdjustmentEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveAdjustmentEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveAdjustmentEntryExists(leaveAdjustmentEntry.Id))
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
            ViewData["AdjustmentTypeId"] = new SelectList(_context.SystemCodeDetails, "Id", "Id", leaveAdjustmentEntry.AdjustmentTypeId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", leaveAdjustmentEntry.EmployeeId);
            return View(leaveAdjustmentEntry);
        }

        // GET: LeaveAdjustmentEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAdjustmentEntry = await _context.LeaveAdjustmentEntries
                .Include(l => l.AdjustmentType)
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveAdjustmentEntry == null)
            {
                return NotFound();
            }

            return View(leaveAdjustmentEntry);
        }

        // POST: LeaveAdjustmentEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveAdjustmentEntry = await _context.LeaveAdjustmentEntries.FindAsync(id);
            if (leaveAdjustmentEntry != null)
            {
                _context.LeaveAdjustmentEntries.Remove(leaveAdjustmentEntry);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveAdjustmentEntryExists(int id)
        {
            return _context.LeaveAdjustmentEntries.Any(e => e.Id == id);
        }
    }
}
