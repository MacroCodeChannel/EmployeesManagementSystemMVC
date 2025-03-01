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

namespace EmployeesManagement.Controllers
{
    public class SystemCodesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SystemCodesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SystemCodes
        public async Task<IActionResult> Index()
        {
            var systcodes = await _context.SystemCodes
                .Include(x => x.CreatedBy)
                .ToListAsync();

            return View(systcodes);
        }
        public async Task<IActionResult> SystemCodeDetail(int id)
        {
            var systcodes = await _context.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Include(x => x.CreatedBy)
                .Where(x=>x.SystemCodeId == id)  
                .ToListAsync();

            return View(systcodes);
        }

        

        // GET: SystemCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCode = await _context.SystemCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemCode == null)
            {
                return NotFound();
            }

            return View(systemCode);
        }

        // GET: SystemCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SystemCodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SystemCode systemCode)
        {
            try
            {
                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                systemCode.CreatedOn = DateTime.Now;
                systemCode.CreatedById = Userid;
                _context.Add(systemCode);
                await _context.SaveChangesAsync(Userid);
                TempData["Message"] = "System Code created successfully";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["Error"] = "Error creating System Code"+ ex.Message;
                return View(systemCode);
            }
        }

        // GET: SystemCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCode = await _context.SystemCodes.FindAsync(id);
            if (systemCode == null)
            {
                return NotFound();
            }
            return View(systemCode);
        }

        // POST: SystemCodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SystemCode systemCode)
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (id != systemCode.Id)
            {
                return NotFound();
            }

            ModelState.Remove("CreatedBy");
            ModelState.Remove("ModifiedBy");
            if (ModelState.IsValid)
            {
                try
                {
                    systemCode.ModifiedById = Userid;
                    systemCode.ModifiedOn = DateTime.Now;
                    _context.Update(systemCode);
                    await _context.SaveChangesAsync(Userid);

                    TempData["Message"] = "System Code updated successfully";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemCodeExists(systemCode.Id))
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
            return View(systemCode);
        }

        // GET: SystemCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCode = await _context.SystemCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemCode == null)
            {
                return NotFound();
            }

            return View(systemCode);
        }

        // POST: SystemCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var systemCode = await _context.SystemCodes.FindAsync(id);
            if (systemCode != null)
            {
                _context.SystemCodes.Remove(systemCode);
            }

            await _context.SaveChangesAsync(Userid);

            TempData["Message"] = "System Code deleted successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool SystemCodeExists(int id)
        {
            return _context.SystemCodes.Any(e => e.Id == id);
        }
    }
}
