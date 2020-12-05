using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabajosGraduacion.Data;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Controllers
{
    public class RegistrosController : Controller
    {
        private readonly TrabajosGraduacionBDContext _context;

        public RegistrosController(TrabajosGraduacionBDContext context)
        {
            _context = context;
        }

        // GET: Registros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registros.ToListAsync());
        }

        // GET: Registros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registros = await _context.Registros
                .FirstOrDefaultAsync(m => m.RegistroId == id);
            if (registros == null)
            {
                return NotFound();
            }

            return View(registros);
        }

        // GET: Registros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistroId,Tipo,Titulo,Autor,Anio,Facultad,Carrera")] Registros registros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registros);
        }

        // GET: Registros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registros = await _context.Registros.FindAsync(id);
            if (registros == null)
            {
                return NotFound();
            }
            return View(registros);
        }

        // POST: Registros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistroId,Tipo,Titulo,Autor,Anio,Facultad,Carrera")] Registros registros)
        {
            if (id != registros.RegistroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrosExists(registros.RegistroId))
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
            return View(registros);
        }

        // GET: Registros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registros = await _context.Registros
                .FirstOrDefaultAsync(m => m.RegistroId == id);
            if (registros == null)
            {
                return NotFound();
            }

            return View(registros);
        }

        // POST: Registros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registros = await _context.Registros.FindAsync(id);
            _context.Registros.Remove(registros);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrosExists(int id)
        {
            return _context.Registros.Any(e => e.RegistroId == id);
        }
    }
}
