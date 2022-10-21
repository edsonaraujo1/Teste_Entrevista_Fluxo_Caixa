using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEdson.Data;
using Rotativa.AspNetCore;

namespace WebAppEdson.Controllers
{
    public class GeraPDFController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeraPDFController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeraPDFController
        public async Task<ActionResult> index()
        {
            return new ViewAsPdf(_context.Caixa.ToListAsync());
        }

        
    }
}
