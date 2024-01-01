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
    public class CalismaGunuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalismaGunuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalismaGunu
        public async Task<IActionResult> Index()
        {
              return _context.CalismaGunleri != null ? 
                          View(await _context.CalismaGunleri.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CalismaGunleri'  is null.");
        }

        // GET: CalismaGunu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CalismaGunleri == null)
            {
                return NotFound();
            }

            var calismaGunu = await _context.CalismaGunleri
                .FirstOrDefaultAsync(m => m.CalismaGunuiId == id);
            if (calismaGunu == null)
            {
                return NotFound();
            }

            return View(calismaGunu);
        }

        // GET: CalismaGunu/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CalismaGunu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CalismaGunuiId,DoktorCalismaGunu")] CalismaGunu calismaGunu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calismaGunu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calismaGunu);
        }

        // GET: CalismaGunu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CalismaGunleri == null)
            {
                return NotFound();
            }

            var calismaGunu = await _context.CalismaGunleri.FindAsync(id);
            if (calismaGunu == null)
            {
                return NotFound();
            }
            return View(calismaGunu);
        }

        // POST: CalismaGunu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CalismaGunuiId,DoktorCalismaGunu")] CalismaGunu calismaGunu)
        {
            if (id != calismaGunu.CalismaGunuiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calismaGunu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalismaGunuExists(calismaGunu.CalismaGunuiId))
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
            return View(calismaGunu);
        }

        // GET: CalismaGunu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CalismaGunleri == null)
            {
                return NotFound();
            }

            var calismaGunu = await _context.CalismaGunleri
                .FirstOrDefaultAsync(m => m.CalismaGunuiId == id);
            if (calismaGunu == null)
            {
                return NotFound();
            }

            return View(calismaGunu);
        }

        // POST: CalismaGunu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CalismaGunleri == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CalismaGunleri'  is null.");
            }
            var calismaGunu = await _context.CalismaGunleri.FindAsync(id);
            if (calismaGunu != null)
            {
                _context.CalismaGunleri.Remove(calismaGunu);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalismaGunuExists(int id)
        {
          return (_context.CalismaGunleri?.Any(e => e.CalismaGunuiId == id)).GetValueOrDefault();
        }
    }
}
