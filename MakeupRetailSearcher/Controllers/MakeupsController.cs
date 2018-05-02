using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MakeupRetailSearcher.Models;

namespace MakeupRetailSearcher.Controllers
{
    public class MakeupsController : Controller
    {
        private readonly MakeupContext _context;

        public MakeupsController(MakeupContext context)
        {
            _context = context;
        }

        // GET: Makeups
        public async Task<IActionResult> Index(string brandSearchString, string typeSearchString)
        {
            var makeup = from m in _context.Makeup
                         select m;

            if (!String.IsNullOrEmpty(brandSearchString))
            {
                makeup = makeup.Where(s => s.Brand.Contains(brandSearchString));
            }

            if (!String.IsNullOrEmpty(typeSearchString))
            {
                makeup = makeup.Where(s => s.Type.Contains(typeSearchString));
            }
            
            return View(await makeup.ToListAsync());
        }

        // GET: Makeups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeup = await _context.Makeup
                .SingleOrDefaultAsync(m => m.ID == id);
            if (makeup == null)
            {
                return NotFound();
            }

            return View(makeup);
        }

        // GET: Makeups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Makeups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Product_Id,Product_Name,Brand,Retailer_Id,Type,Price")] Makeup makeup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(makeup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(makeup);
        }

        // GET: Makeups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeup = await _context.Makeup.SingleOrDefaultAsync(m => m.ID == id);
            if (makeup == null)
            {
                return NotFound();
            }
            return View(makeup);
        }

        // POST: Makeups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Product_Id,Product_Name,Brand,Retailer_Id,Type,Price")] Makeup makeup)
        {
            if (id != makeup.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makeup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakeupExists(makeup.ID))
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
            return View(makeup);
        }

        // GET: Makeups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeup = await _context.Makeup
                .SingleOrDefaultAsync(m => m.ID == id);
            if (makeup == null)
            {
                return NotFound();
            }

            return View(makeup);
        }

        // POST: Makeups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var makeup = await _context.Makeup.SingleOrDefaultAsync(m => m.ID == id);
            _context.Makeup.Remove(makeup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MakeupExists(int id)
        {
            return _context.Makeup.Any(e => e.ID == id);
        }
    }
}
