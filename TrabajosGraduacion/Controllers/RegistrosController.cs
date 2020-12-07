using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using TrabajosGraduacion.Data;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Controllers
{
    public class RegistrosController : Controller
    {
        private readonly TrabajosGraduacionContext _context;

        public RegistrosController(TrabajosGraduacionContext context)
        {
            _context = context;
        }

        //// GET: Registros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registro.ToListAsync());
        }


        // GET: Registros/Create
        public IActionResult Ingresar()
        {
            return View();
        }

        // POST: Registros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ingresar([Bind("RegistroId,Tipo,Titulo,Autor,Anio,Facultad,Carrera")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index).Replace("RegistrosController", "HomeController"));
            }
            return View(registro);
        }

        // GET: Registros/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registro.FindAsync(id);
            if (registro == null)
            {
                return NotFound();
            }
            return View(registro);
        }

        // POST: Registros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("RegistroId,Tipo,Titulo,Autor,Anio,Facultad,Carrera")] Registro registro)
        {
            if (id != registro.RegistroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroExists(registro.RegistroId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Editar_Eliminar));
            }
            return View(registro);
        }

        // GET: Registros/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registro
                .FirstOrDefaultAsync(m => m.RegistroId == id);
            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);
        }

        // POST: Registros/Delete/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registro = await _context.Registro.FindAsync(id);
            _context.Registro.Remove(registro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Editar_Eliminar));
        }

        private bool RegistroExists(int id)
        {
            return _context.Registro.Any(e => e.RegistroId == id);
        }

        // GET: Busqueda Registros
        public async Task<IActionResult> Busqueda()
        {
            return View(await _context.Registro.ToListAsync());
        }

        // GET: Editar Eliminar Registros
        public async Task<IActionResult> Editar_Eliminar()
        {
            return View(await _context.Registro.ToListAsync());
        }

        public IActionResult Estadistica()
        {
            return View();
        }



    }
}
