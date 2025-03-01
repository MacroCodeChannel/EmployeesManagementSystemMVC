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
using AutoMapper;
using System.Linq.Expressions;
using EmployeesManagement.Helpers;

namespace EmployeesManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public EmployeesController(IMapper mapper, IConfiguration configuration, ApplicationDbContext context)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }

        // GET: Employees
        public async Task<IActionResult> Index(EmployeeViewModel employees)
        {

            Expression<Func<Employee, bool>> filter = x => x.Id > 0;
            Expression<Func<Employee, bool>> filters ;

            var rawdata = _context.Employees.Include(x=>x.Status).AsQueryable();

            if (!string.IsNullOrEmpty(employees.FullName.Trim()))
            {
                filters = x => x.FullName.Contains(employees.FullName);
                filter = filter.And(filters);
            }

            if (employees.PhoneNumber > 0)
            {
                filters = x => x.PhoneNumber == employees.PhoneNumber;
                filter = filter.And(filters);
            }

            if (!string.IsNullOrEmpty(employees.EmailAddress))
            {
                filters = x => x.EmailAddress == employees.EmailAddress;
                filter = filter.And(filters);
            }

            if (!string.IsNullOrEmpty(employees.EmpNo))
            {
                filters = x => x.EmpNo == employees.EmpNo;
                filter = filter.And(filters);
            }

            employees.Employees = await rawdata.Where(filter).ToListAsync();

            return View(employees);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(x=>x.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {

            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "Name");
            ViewData["EmploymentTermsId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "EmploymentTerms"), "Id", "Description");
            ViewData["DisabilityId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "DisabilityTypes"), "Id", "Description");

            ViewData["GenderId"] = new SelectList(_context.SystemCodeDetails.Include(x=>x.SystemCode).Where(x=>x.SystemCode.Code=="Gender"), "Id", "Description");
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
            ViewData["DesignationId"] = new SelectList(_context.Designations, "Id", "Name");
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel newemployee, IFormFile employeephoto)
        {
            try
            {
                var employee = new Employee();
                _mapper.Map(newemployee, employee);

                if (employeephoto != null && employeephoto.Length > 0)
                {
                    var fileName = "EmployeePhoto_" + DateTime.Now.ToString("yyyymmddhhmmss") + "_" + employeephoto.FileName;
                    var path = _configuration["FileSettings:UploadFolder"]!;
                    var filepath = Path.Combine(path, fileName);
                    var stream = new FileStream(filepath, FileMode.Create);
                    await employeephoto.CopyToAsync(stream);
                    employee.Photo = fileName;
                }

                var statusId = await _context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "EmployeeStatus" && x.Code == "Active").FirstOrDefaultAsync();
                var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.CreatedById = Userid;
                employee.CreatedOn = DateTime.Now;
                employee.StatusId = statusId.Id;

                _context.Add(employee);
                await _context.SaveChangesAsync(Userid);

                TempData["Message"] = "Employee  Created Successfully";

                return RedirectToAction(nameof(Index));


                ViewData["DisabilityId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "DisabilityTypes"), "Id", "Description", employee.DisabilityId);
                ViewData["BankId"] = new SelectList(_context.Banks, "Id", "Name", employee.BankId);
                ViewData["EmploymentTermsId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "EmploymentTerms"), "Id", "Description", employee.EmploymentTermsId);
                ViewData["GenderId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "Gender"), "Id", "Description", employee.GenderId);
                ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name", employee.CountryId);
                ViewData["DesignationId"] = new SelectList(_context.Designations, "Id", "Name", employee.DesignationId);
                ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", employee.DepartmentId);
                return View(employee);
            }
            catch (Exception ex)
            {

                TempData["Error"] = "Employee could be created Successfully-"+ex.Message;
                return View(newemployee);
            }
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            ViewData["GenderId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "Gender"), "Id", "Description");
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
            ViewData["DesignationId"] = new SelectList(_context.Designations, "Id", "Name");
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "Name");
            ViewData["EmploymentTermsId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "EmploymentTerms"), "Id", "Description");
            ViewData["DisabilityId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "DisabilityTypes"), "Id", "Description");
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Bank");
            ModelState.Remove("Country");
            ModelState.Remove("Department");
            ModelState.Remove("Designation");
            ModelState.Remove("ApplicationUser");
            ModelState.Remove("CreatedBy");
            ModelState.Remove("ModifiedBy");
            ModelState.Remove("Employee");
            ModelState.Remove("Gender");
            ModelState.Remove("Disability");
            ModelState.Remove("Status");
            ModelState.Remove("CauseofInactivity");
            ModelState.Remove("Reasonfortermination");
            ModelState.Remove("EmploymentTerms");

            if (ModelState.IsValid)
            {
                try
                {

                    var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    employee.ModifiedById = userid;
                    employee.ModifiedOn = DateTime.Now;
                    _context.Update(employee);
                    await _context.SaveChangesAsync(userid);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
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

            ViewData["GenderId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "Gender"), "Id", "Description", employee.GenderId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name", employee.CountryId);
            ViewData["DesignationId"] = new SelectList(_context.Designations, "Id", "Name", employee.DesignationId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", employee.DepartmentId);
            ViewData["BankId"] = new SelectList(_context.Banks, "Id", "Name",employee.BankId);
            ViewData["EmploymentTermsId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "EmploymentTerms"), "Id", "Description",employee.EmploymentTermsId);
            ViewData["DisabilityId"] = new SelectList(_context.SystemCodeDetails.Include(x => x.SystemCode).Where(x => x.SystemCode.Code == "DisabilityTypes"), "Id", "Description",employee.DisabilityId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
