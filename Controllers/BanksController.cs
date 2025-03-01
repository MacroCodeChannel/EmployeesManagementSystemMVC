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
    public class BanksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BanksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Banks
        public async Task<IActionResult> Index()
        {
            var banks = await _context.Banks
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .ToListAsync();
            return View(banks);
        }

        // GET: Banks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // GET: Banks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Bank bank)
        {
            try
            {

                ModelState.Remove("CreatedBy");
                ModelState.Remove("ModifiedBy");
                if (ModelState.IsValid)
                {
                    var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    bank.CreatedById = Userid;
                    bank.CreatedOn = DateTime.Now;
                    _context.Add(bank);
                    await _context.SaveChangesAsync(Userid);
                    TempData["Message"] = "Bank created successfully";
                    return RedirectToAction(nameof(Index));
                }
            }catch(Exception ex)
            {
                TempData["Error"] = "Error creating Bank" + ex.Message;
                return View(bank);
            }
            return View(bank);
        }

        // GET: Banks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (bank == null)
            {
                return NotFound();
            }
            return View(bank);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Bank bank)
        {
            if (id != bank.Id)
            {
                return NotFound();
            }

            try
            {
                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                bank.ModifiedById = Userid;
                bank.ModifiedOn = DateTime.Now;
                _context.Update(bank);
                await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "Bank updated successfully";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankExists(bank.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

            return View(bank);
        }

        // GET: Banks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bank = await _context.Banks
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bank = await _context.Banks.FindAsync(id);
            if (bank != null)
            {
                _context.Banks.Remove(bank);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankExists(int id)
        {
            return _context.Banks.Any(e => e.Id == id);
        }
    }
}
