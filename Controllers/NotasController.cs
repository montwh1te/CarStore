using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarStore.Data;
using CarStore.Models;
using CarStore.Models.ViewModels;

namespace CarStore.Controllers
{
    public class NotasController : Controller
    {
        private readonly AppDbContext _context;

        public NotasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Notas.Include(n => n.Carro).Include(n => n.Comprador).Include(n => n.Vendedor);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas
                .Include(n => n.Carro)
                .Include(n => n.Comprador)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            // ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "MarcaModelo");
            // ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "NomeCPF");
            // ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "NomeMatricula");
            ViewModelNota viewModelNota = new ViewModelNota();
            viewModelNota.Carros = _context.Carros.ToList();
            viewModelNota.Clientes = _context.Clientes.ToList();
            viewModelNota.Vendedores = _context.Vendedores.ToList();

            return View(viewModelNota);
        }

        // POST: Notas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,DataEmissao,Garantia,ValorVenda,CompradorId,VendedorId,CarroId")] Nota nota)
        {
            //if (ModelState.IsValid)
            //{
            _context.Add(nota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //} else
            //{
            //   var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            //  Console.WriteLine("Erros: " + string.Join(", ", errors));
            //}
            //ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "MarcaModelo", nota.CarroId);
            //ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "NomeCPF", nota.CompradorId);
            //ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "NomeMatricula", nota.VendedorId);

            /* ViewModelNota viewModelNota = new ViewModelNota();
            viewModelNota.Nota = nota;
            viewModelNota.Carros = _context.Carros.ToList();
            viewModelNota.Clientes = _context.Clientes.ToList();
            viewModelNota.Vendedores = _context.Vendedores.ToList(); 
            return View(viewModelNota); */
        }



        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas.FindAsync(id);
            if (nota == null)
            {
                return NotFound();
            }
            ViewModelNota viewModelNota = new ViewModelNota();
            viewModelNota.Nota = nota;
            viewModelNota.Carros = _context.Carros.ToList();
            viewModelNota.Clientes = _context.Clientes.ToList();
            viewModelNota.Vendedores = _context.Vendedores.ToList(); 
            return View(viewModelNota);
        }

        // POST: Notas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,DataEmissao,Garantia,ValorVenda,CompradorId,VendedorId,CarroId")] Nota nota)
        {
            /*if (id != nota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {*/
                _context.Update(nota);
                await _context.SaveChangesAsync();
                /* }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaExists(nota.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                } */
                return RedirectToAction(nameof(Index));
            //}
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas
                .Include(n => n.Carro)
                .Include(n => n.Comprador)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Notas == null)
            {
                return Problem("Entity set 'AppDbContext.Notas'  is null.");
            }
            var nota = await _context.Notas.FindAsync(id);
            if (nota != null)
            {
                _context.Notas.Remove(nota);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaExists(int id)
        {
          return (_context.Notas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
