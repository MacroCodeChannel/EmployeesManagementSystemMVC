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
    public class CountriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CountriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Countries
        public async Task<IActionResult> Index()
        {
            var country = await _context.Countries
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .ToListAsync();

            return View(country);
        }

        // GET: Countries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Countries
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // GET: Countries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Country country)
        {
            try
            {

                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                country.CreatedById = Userid;
                country.CreatedOn = DateTime.Now;
                ModelState.Remove("CreatedBy");
                ModelState.Remove("ModifiedBy");
                if (ModelState.IsValid)
                {
                    _context.Add(country);
                    await _context.SaveChangesAsync(Userid);
                    TempData["Message"] = "Country created successfully";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error creating Country" + ex.Message;
                return View(country);
            }
            return View(country);
        }

        // GET: Countries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Countries
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            if (country == null)
            {
                return NotFound();
            }
            return View(country);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Country country)
        {
            if (id != country.Id)
            {
                return NotFound();
            }

            ModelState.Remove("CreatedBy");
            ModelState.Remove("ModifiedBy");
            if (ModelState.IsValid)
            {
                try
                {

                    var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    country.ModifiedById = Userid;
                    country.ModifiedOn = DateTime.Now;
                    _context.Update(country);
                    await _context.SaveChangesAsync(Userid);


                    TempData["Message"] = "Country updated successfully";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountryExists(country.Id))
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
            return View(country);
        }

        // GET: Countries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Countries
                .Include(x => x.CreatedBy)
                .Include(x => x.ModifiedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country != null)
            {
                _context.Countries.Remove(country);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CountryExists(int id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }
    }
}
