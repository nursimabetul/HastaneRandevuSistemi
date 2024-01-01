using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HastaneRandevuSistemi.Data;
using HastaneRandevuSistemi.Models;

namespace HastaneRandevuSistemi.Controllers
{
    public class CalismaSaatiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalismaSaatiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalismaSaati
        public async Task<IActionResult> Index()
        {
              return _context.CalismaSaati != null ? 
                          View(await _context.CalismaSaati.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CalismaSaati'  is null.");
        }

        // GET: CalismaSaati/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CalismaSaati == null)
            {
                return NotFound();
            }

            var calismaSaati = await _context.CalismaSaati
                .FirstOrDefaultAsync(m => m.CalismaSaatiId == id);
            if (calismaSaati == null)
            {
                return NotFound();
            }

            return View(calismaSaati);
        }

        // GET: CalismaSaati/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CalismaSaati/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CalismaSaatiId,DoktorCalismaSaati")] CalismaSaati calismaSaati)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calismaSaati);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calismaSaati);
        }

        // GET: CalismaSaati/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CalismaSaati == null)
            {
                return NotFound();
            }

            var calismaSaati = await _context.CalismaSaati.FindAsync(id);
            if (calismaSaati == null)
            {
                return NotFound();
            }
            return View(calismaSaati);
        }

        // POST: CalismaSaati/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CalismaSaatiId,DoktorCalismaSaati")] CalismaSaati calismaSaati)
        {
            if (id != calismaSaati.CalismaSaatiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calismaSaati);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalismaSaatiExists(calismaSaati.CalismaSaatiId))
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
            return View(calismaSaati);
        }

        // GET: CalismaSaati/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CalismaSaati == null)
            {
                return NotFound();
            }

            var calismaSaati = await _context.CalismaSaati
                .FirstOrDefaultAsync(m => m.CalismaSaatiId == id);
            if (calismaSaati == null)
            {
                return NotFound();
            }

            return View(calismaSaati);
        }

        // POST: CalismaSaati/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CalismaSaati == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CalismaSaati'  is null.");
            }
            var calismaSaati = await _context.CalismaSaati.FindAsync(id);
            if (calismaSaati != null)
            {
                _context.CalismaSaati.Remove(calismaSaati);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalismaSaatiExists(int id)
        {
          return (_context.CalismaSaati?.Any(e => e.CalismaSaatiId == id)).GetValueOrDefault();
        }
    }
}
