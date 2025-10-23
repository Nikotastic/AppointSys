using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppointSysWeb.Data;
using AppointSysWeb.Data.Entities;

namespace AppointSysWeb.Controllers
{
    public class ShiftController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShiftController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Shift
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shifts.Include(s => s.Affiliate).Include(s => s.Box).Include(s => s.ServedByEmployee).Include(s => s.Status).Include(s => s.TypesOfService);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Shift/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts
                .Include(s => s.Affiliate)
                .Include(s => s.Box)
                .Include(s => s.ServedByEmployee)
                .Include(s => s.Status)
                .Include(s => s.TypesOfService)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // GET: Shift/Create
        public IActionResult Create()
        {
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "Id");
            ViewData["BoxId"] = new SelectList(_context.Boxes, "Id", "Name");
            ViewData["ServedByEmployeeId"] = new SelectList(_context.Employees, "Id", "Id");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id");
            ViewData["TypesOfServiceId"] = new SelectList(_context.TypeOfServices, "Id", "Name");
            return View();
        }

        // POST: Shift/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,RequestDate,DateAttention,StatusId,TypesOfServiceId,AffiliateId,BoxId,ServedByEmployeeId")] Shift shift)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shift);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "Id", shift.AffiliateId);
            ViewData["BoxId"] = new SelectList(_context.Boxes, "Id", "Name", shift.BoxId);
            ViewData["ServedByEmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shift.ServedByEmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id", shift.StatusId);
            ViewData["TypesOfServiceId"] = new SelectList(_context.TypeOfServices, "Id", "Name", shift.TypesOfServiceId);
            return View(shift);
        }

        // GET: Shift/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts.FindAsync(id);
            if (shift == null)
            {
                return NotFound();
            }
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "Id", shift.AffiliateId);
            ViewData["BoxId"] = new SelectList(_context.Boxes, "Id", "Name", shift.BoxId);
            ViewData["ServedByEmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shift.ServedByEmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id", shift.StatusId);
            ViewData["TypesOfServiceId"] = new SelectList(_context.TypeOfServices, "Id", "Name", shift.TypesOfServiceId);
            return View(shift);
        }

        // POST: Shift/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Number,RequestDate,DateAttention,StatusId,TypesOfServiceId,AffiliateId,BoxId,ServedByEmployeeId")] Shift shift)
        {
            if (id != shift.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shift);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftExists(shift.Id))
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
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "Id", shift.AffiliateId);
            ViewData["BoxId"] = new SelectList(_context.Boxes, "Id", "Name", shift.BoxId);
            ViewData["ServedByEmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shift.ServedByEmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Id", shift.StatusId);
            ViewData["TypesOfServiceId"] = new SelectList(_context.TypeOfServices, "Id", "Name", shift.TypesOfServiceId);
            return View(shift);
        }

        // GET: Shift/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts
                .Include(s => s.Affiliate)
                .Include(s => s.Box)
                .Include(s => s.ServedByEmployee)
                .Include(s => s.Status)
                .Include(s => s.TypesOfService)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // POST: Shift/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shift = await _context.Shifts.FindAsync(id);
            if (shift != null)
            {
                _context.Shifts.Remove(shift);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShiftExists(int id)
        {
            return _context.Shifts.Any(e => e.Id == id);
        }
    }
}
