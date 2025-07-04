﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCafeteria.Models;

namespace WebCafeteria.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        private readonly LabCafeteriaContext _context;

        public CategoriasController(LabCafeteriaContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categoria.ToListAsync());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nombre")] Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                return Json(new { success = false, mensaje = "El nombre es obligatorio." });

            var existe = await _context.Categoria
                .AnyAsync(c => c.Nombre.ToLower() == categoria.Nombre.ToLower() && c.Estado == 1);

            if (existe)
                return Json(new { success = false, mensaje = "Ya existe una categoría con ese nombre." });

            categoria.Estado = 1;
            _context.Categoria.Add(categoria);
            await _context.SaveChangesAsync();
            return Json(new { success = true, mensaje = "Categoría agregada exitosamente." });
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Estado")] Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(categoria.Id))
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
            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria != null)
            {
                _context.Categoria.Remove(categoria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.Id == id);
        }
        // listar en productos
        [HttpGet]
        public async Task<JsonResult> Listar()
        {
            var categorias = await _context.Categoria
                .Where(c => c.Estado == 1)
                .Select(c => new { c.Id, c.Nombre })
                .ToListAsync();
            return Json(categorias);
        }
        //para recargar eliminar
        [HttpPost]
        public async Task<JsonResult> Eliminar(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
                return Json(new { success = false, mensaje = "Categoría no encontrada." });

            var enUso = await _context.Productos.AnyAsync(p => p.IdCategoria == id && p.Estado == 1);
            if (enUso)
                return Json(new { success = false, mensaje = "Esta categoría no puede ser eliminada porque hay productos que la están usando." });

            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();
            return Json(new { success = true, mensaje = "Categoría eliminada correctamente." });
        }
    }
}