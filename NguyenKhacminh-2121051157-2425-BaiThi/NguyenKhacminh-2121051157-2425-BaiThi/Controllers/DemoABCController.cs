using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenKhacMinh_2121051157_BaiThi.Data;
using nguyenkhacminh_2121051157_2425_BaiThi.Models;

namespace NguyenKhacminh_2121051157_2425_BaiThi.Controllers
{
    public class DemoABCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DemoABCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DemoABC
        public async Task<IActionResult> Index()
        {
            return View(await _context.DemoABC.ToListAsync());
        }

        // GET: DemoABC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoABC = await _context.DemoABC
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoABC == null)
            {
                return NotFound();
            }

            return View(demoABC);
        }

        // GET: DemoABC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DemoABC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age")] DemoABC demoABC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demoABC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demoABC);
        }

        // GET: DemoABC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoABC = await _context.DemoABC.FindAsync(id);
            if (demoABC == null)
            {
                return NotFound();
            }
            return View(demoABC);
        }

        // POST: DemoABC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age")] DemoABC demoABC)
        {
            if (id != demoABC.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demoABC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemoABCExists(demoABC.Id))
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
            return View(demoABC);
        }

        // GET: DemoABC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoABC = await _context.DemoABC
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoABC == null)
            {
                return NotFound();
            }

            return View(demoABC);
        }

        // POST: DemoABC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demoABC = await _context.DemoABC.FindAsync(id);
            if (demoABC != null)
            {
                _context.DemoABC.Remove(demoABC);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemoABCExists(int id)
        {
            return _context.DemoABC.Any(e => e.Id == id);
        }
    }
}
