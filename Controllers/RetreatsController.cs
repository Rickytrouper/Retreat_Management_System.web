using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Retreat_Management_System.web.Data;

namespace Retreat_Management_System.web.Controllers
{
    public class RetreatsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RetreatsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Retreats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Retreat.ToListAsync());
        }

        // GET: Retreats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retreat = await _context.Retreat
                .FirstOrDefaultAsync(m => m.RetreatID == id);
            if (retreat == null)
            {
                return NotFound();
            }

            return View(retreat);
        }

        // GET: Retreats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Retreats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RetreatID,RetreatName,Description,Location,StartDate,EndDate,Price,Capacity")] Retreat retreat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(retreat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(retreat);
        }

        // GET: Retreats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retreat = await _context.Retreat.FindAsync(id);
            if (retreat == null)
            {
                return NotFound();
            }
            return View(retreat);
        }

        // POST: Retreats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RetreatID,RetreatName,Description,Location,StartDate,EndDate,Price,Capacity")] Retreat retreat)
        {
            if (id != retreat.RetreatID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(retreat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RetreatExists(retreat.RetreatID))
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
            return View(retreat);
        }

        // GET: Retreats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retreat = await _context.Retreat
                .FirstOrDefaultAsync(m => m.RetreatID == id);
            if (retreat == null)
            {
                return NotFound();
            }

            return View(retreat);
        }

        // POST: Retreats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var retreat = await _context.Retreat.FindAsync(id);
            if (retreat != null)
            {
                _context.Retreat.Remove(retreat);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RetreatExists(int id)
        {
            return _context.Retreat.Any(e => e.RetreatID == id);
        }
    }
}
