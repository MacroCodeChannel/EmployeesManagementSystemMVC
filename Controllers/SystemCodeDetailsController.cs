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

namespace EmployeesManagement.Controllers
{
    public class SystemCodeDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SystemCodeDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SystemCodeDetails
        public async Task<IActionResult> Index(SystemCodeDetailViewModel vm)
        {
           vm.SystemCodeDetails  = await _context.SystemCodeDetails
                .Include(s => s.SystemCode)
                .Include(s=>s.CreatedBy)
                .ToListAsync();

            return View(vm);
        }

        // GET: SystemCodeDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCodeDetail = await _context.SystemCodeDetails
                .Include(s => s.SystemCode)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemCodeDetail == null)
            {
                return NotFound();
            }

            return View(systemCodeDetail);
        }

        // GET: SystemCodeDetails/Create
        public IActionResult Create()
        {
            ViewData["SystemCodeId"] = new SelectList(_context.SystemCodes, "Id", "Description");
            return View();
        }

        // POST: SystemCodeDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SystemCodeDetail systemCodeDetail)
        {
            try
            {

                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                systemCodeDetail.CreatedOn = DateTime.Now;
                systemCodeDetail.CreatedById = Userid;

                _context.Add(systemCodeDetail);
                await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "System Code Detail created successfully";

                return RedirectToAction(nameof(Index));
            }catch(Exception ex)
            {
                TempData["Error"] = "Error creating System Code Detail" +ex.Message;
                return View(systemCodeDetail);
            }
            ViewData["SystemCodeId"] = new SelectList(_context.SystemCodes, "Id", "Description", systemCodeDetail.SystemCodeId);
  
        }

        // GET: SystemCodeDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCodeDetail = await _context.SystemCodeDetails.FindAsync(id);
            if (systemCodeDetail == null)
            {
                return NotFound();
            }

            ViewData["SystemCodeId"] = new SelectList(_context.SystemCodes, "Id", "Description", systemCodeDetail.SystemCodeId);
            
            return View(systemCodeDetail);
        }

        // POST: SystemCodeDetails/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,SystemCodeDetail systemCodeDetail)
        {
            if (id != systemCodeDetail.Id)
            {
                return NotFound();
            }
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            systemCodeDetail.ModifiedById = Userid;
            systemCodeDetail.ModifiedOn = DateTime.Now;

            ModelState.Remove("CreatedBy");
            ModelState.Remove("ModifiedBy");
            ModelState.Remove("SystemCode");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(systemCodeDetail);
                    await _context.SaveChangesAsync(Userid);


                    TempData["Message"] = "System Code Details updated successfully";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemCodeDetailExists(systemCodeDetail.Id))
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
            ViewData["SystemCodeId"] = new SelectList(_context.SystemCodes, "Id", "Description", systemCodeDetail.SystemCodeId);
            return View(systemCodeDetail);
        }

        // GET: SystemCodeDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCodeDetail = await _context.SystemCodeDetails
                .Include(s => s.SystemCode)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemCodeDetail == null)
            {
                return NotFound();
            }

            return View(systemCodeDetail);
        }

        // POST: SystemCodeDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var systemCodeDetail = await _context.SystemCodeDetails.FindAsync(id);
            if (systemCodeDetail != null)
            {
                _context.SystemCodeDetails.Remove(systemCodeDetail);
            }

            await _context.SaveChangesAsync(Userid);

            TempData["Message"] = "System Code Details deleted successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool SystemCodeDetailExists(int id)
        {
            return _context.SystemCodeDetails.Any(e => e.Id == id);
        }
    }
}
