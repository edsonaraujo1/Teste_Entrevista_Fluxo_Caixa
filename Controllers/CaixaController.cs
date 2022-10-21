using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using WebAppEdson.Data;
using WebAppEdson.Models;

namespace WebAppEdson.Controllers
{
    [Authorize]
    public class CaixaController : Controller
    {
        const string SessionNome = "Buscar";
        private readonly ApplicationDbContext _context;

        public CaixaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Caixa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caixa.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult> index(string busca)
        {
            ViewData["Caixa"] = busca;
            Session.Busc_1 = busca;
            
            var caixa = from x in _context.Caixa select x;
            if (!String.IsNullOrEmpty(busca))
            {
                caixa = caixa.Where(x => x.Descricao.Contains(busca) || x.Nome.Contains(busca) || x.Tipo.Contains(busca) || x.Data.Contains(busca) || x.Forma.Contains(busca));
            }
            return View(await caixa.AsNoTracking().ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> RotativaPDF()
        {
            string busca = Session.Busc_1; 
            var caixa = from x in _context.Caixa select x;
            if (!String.IsNullOrEmpty(busca))
            {
                caixa = caixa.Where(x => x.Descricao.Contains(busca) || x.Nome.Contains(busca) || x.Tipo.Contains(busca) || x.Data.Contains(busca) || x.Forma.Contains(busca));
            }
            var person = await caixa.AsNoTracking().ToListAsync();

            var pdf = new ViewAsPdf(person);

            return pdf;
        }

        // GET: Caixa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixa == null)
            {
                return NotFound();
            }

            return View(caixa);
        }

        // GET: Caixa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Caixa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Nome,Descricao,Forma,Tipo,Valor")] Caixa caixa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caixa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caixa);
        }

        // GET: Caixa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa.FindAsync(id);
            if (caixa == null)
            {
                return NotFound();
            }
            return View(caixa);
        }

        // POST: Caixa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Nome,Descricao,Forma,Tipo,Valor")] Caixa caixa)
        {
            if (id != caixa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caixa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaixaExists(caixa.Id))
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
            return View(caixa);
        }

        // GET: Caixa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixa == null)
            {
                return NotFound();
            }

            return View(caixa);
        }

        // POST: Caixa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caixa = await _context.Caixa.FindAsync(id);
            _context.Caixa.Remove(caixa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaixaExists(int id)
        {
            return _context.Caixa.Any(e => e.Id == id);
        }

               
    }
}
