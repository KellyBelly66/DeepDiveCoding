using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CellPhones.Models;

namespace CellPhones.Controllers
{
    public class CellphonesController : Controller
    {
        private readonly CellPhonesContext _context;

        public CellphonesController(CellPhonesContext context)
        {
            _context = context;
        }

        // GET: Cellphones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cellphone.ToListAsync());
        }

        // GET: Cellphones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cellphone = await _context.Cellphone
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cellphone == null)
            {
                return NotFound();
            }

            return View(cellphone);
        }

        // GET: Cellphones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cellphones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Make,Model,OS,ScreenSize,Memory,Price,Prepaid")] Cellphone cellphone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cellphone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cellphone);
        }

        // GET: Cellphones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cellphone = await _context.Cellphone.SingleOrDefaultAsync(m => m.ID == id);
            if (cellphone == null)
            {
                return NotFound();
            }
            return View(cellphone);
        }

        // POST: Cellphones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Make,Model,OS,ScreenSize,Memory,Price,Prepaid")] Cellphone cellphone)
        {
            if (id != cellphone.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cellphone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CellphoneExists(cellphone.ID))
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
            return View(cellphone);
        }

        // GET: Cellphones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cellphone = await _context.Cellphone
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cellphone == null)
            {
                return NotFound();
            }

            return View(cellphone);
        }

        // POST: Cellphones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cellphone = await _context.Cellphone.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cellphone.Remove(cellphone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CellphoneExists(int id)
        {
            return _context.Cellphone.Any(e => e.ID == id);
        }
    }
}
