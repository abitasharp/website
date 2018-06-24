using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abitasharp.Models;

namespace Abitasharp.Controllers
{
    public class ExamplesController : Controller
    {
        private readonly ExampleContext _context;

        public ExamplesController(ExampleContext context)
        {
            _context = context;
        }

        // GET: Examples
        public async Task<IActionResult> Index()
        {
            return View("GestioneAnnunci");
        }

        // GET: Examples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var example = await _context.Example
                .SingleOrDefaultAsync(m => m.ID == id);
            if (example == null)
            {
                return NotFound();
            }

            return View(example);
        }

        // GET: Examples/Create
        public async Task<IActionResult> Create(int ID, string testo)
        {
            Example example = new Example();
            example.ID = ID;
            example.Testo = testo;
            _context.Add(example);
            await _context.SaveChangesAsync();
            return View("CercaAnnunci");
        }

        // POST: Examples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Testo")] Example example)
        {
            if (ModelState.IsValid)
            {
                _context.Add(example);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(example);
        }

        // GET: Examples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var example = await _context.Example.SingleOrDefaultAsync(m => m.ID == id);
            if (example == null)
            {
                return NotFound();
            }
            return View(example);
        }

        // POST: Examples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Testo")] Example example)
        {
            if (id != example.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(example);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExampleExists(example.ID))
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
            return View(example);
        }

        // GET: Examples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var example = await _context.Example
                .SingleOrDefaultAsync(m => m.ID == id);
            if (example == null)
            {
                return NotFound();
            }

            return View(example);
        }

        // POST: Examples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var example = await _context.Example.SingleOrDefaultAsync(m => m.ID == id);
            _context.Example.Remove(example);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExampleExists(int id)
        {
            return _context.Example.Any(e => e.ID == id);
        }
    }
}