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
using EmployeesManagement.ViewModels;
using System.Linq.Expressions;
using EmployeesManagement.Helpers;

namespace EmployeesManagement.Controllers
{
    public class HolidaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HolidaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Holidays
        public async Task<IActionResult> Index(HolidayViewModel vm)
        {
            Expression<Func<Holiday, bool>> filter = x => x.Id > 0;
            Expression<Func<Holiday, bool>> filters;

            var holidays =  _context.Holidays
                .Include(x=>x.CreatedBy)
                .AsQueryable();

            if (!string.IsNullOrEmpty(vm.Title))
            {
                filters = x => x.Title.Contains(vm.Title);
                filter = filter.And(filters);
            }
            if (!string.IsNullOrEmpty(vm.Description))
            {
                filters = x => x.Description.Contains(vm.Description);
                filter = filter.And(filters);
            }
            if (vm.EndDate !=null)
            {
                filters = x => x.EndDate == vm.EndDate;
                filter = filter.And(filters);
            }
            if (vm.StartDate != null)
            {
                filters = x => x.StartDate == vm.StartDate;
                filter = filter.And(filters);
            }

            vm.Holidays = await holidays.Where(filter).ToListAsync();

            return View(vm);
        }

        // GET: Holidays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _context.Holidays
                .FirstOrDefaultAsync(m => m.Id == id);
            if (holiday == null)
            {
                return NotFound();
            }

            return View(holiday);
        }

        // GET: Holidays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Holidays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Holiday holiday)
        {
            try
            {
                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                holiday.CreatedById = Userid;
                holiday.CreatedOn = DateTime.Now;
                _context.Add(holiday);
                await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "Holiday created successfully";

                return RedirectToAction(nameof(Index));

              

            }
            catch(Exception ex)
            {
                TempData["Error"] = "An error occurred while creating the holiday"+ ex.Message;
                return View(holiday);
            }

        }

        // GET: Holidays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _context.Holidays.FindAsync(id);
            if (holiday == null)
            {
                return NotFound();
            }
            return View(holiday);
        }

        // POST: Holidays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Holiday holiday)
        {
            if (id != holiday.Id)
            {
                return NotFound();
            }
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            holiday.ModifiedById = Userid;
            holiday.ModifiedOn = DateTime.Now;
            try
                {
                    _context.Update(holiday);
                    await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "Holiday updated successfully";
            }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HolidayExists(holiday.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            return View(holiday);
        }

        // GET: Holidays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _context.Holidays
                .Include(x=>x.CreatedBy)
                .Include(x=>x.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (holiday == null)
            {
                return NotFound();
            }

            return View(holiday);
        }

        // POST: Holidays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var holiday = await _context.Holidays.FindAsync(id);
            if (holiday != null)
            {
                _context.Holidays.Remove(holiday);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HolidayExists(int id)
        {
            return _context.Holidays.Any(e => e.Id == id);
        }
    }
}
