using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AT_CRUD.Data;
using AT_CRUD.Models;

namespace AT_CRUD.Controllers
{
    public class AmigosController : Controller
    {
        private readonly AT_CRUDContext _context;

        public AmigosController(AT_CRUDContext context)
        {
            _context = context;
        }

        // GET: Amigoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Amigo.ToListAsync());

        }

        [HttpPost]

        public async Task<IActionResult> Index(string nome)
        {
            var dados = await _context.Amigo.Where(a => a.Nome == nome).ToListAsync();

            return View("Index", dados);
        }

        // GET: Amigoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigo = await _context.Amigo
                .FirstOrDefaultAsync(m => m.AmigoId == id);
            if (amigo == null)
            {
                return NotFound();
            }

            return View(amigo);
        }

        // GET: Amigoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Amigoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmigoId,Nome,SobreNome,Idade,Aniversario")] Amigo amigo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amigo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amigo);
        }

        // GET: Amigoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigo = await _context.Amigo.FindAsync(id);
            if (amigo == null)
            {
                return NotFound();
            }
            return View(amigo);
        }

        // POST: Amigoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AmigoId,Nome,SobreNome,Idade,Aniversario")] Amigo amigo)
        {
            if (id != amigo.AmigoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amigo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmigoExists(amigo.AmigoId))
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
            return View(amigo);
        }

        // GET: Amigoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amigo = await _context.Amigo
                .FirstOrDefaultAsync(m => m.AmigoId == id);
            if (amigo == null)
            {
                return NotFound();
            }

            return View(amigo);
        }

        // POST: Amigoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amigo = await _context.Amigo.FindAsync(id);
            _context.Amigo.Remove(amigo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmigoExists(int id)
        {
            return _context.Amigo.Any(e => e.AmigoId == id);
        }
    }
}
