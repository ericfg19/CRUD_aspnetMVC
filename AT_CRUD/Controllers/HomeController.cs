using AT_CRUD.Data;
using AT_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AT_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly AT_CRUDContext _context;

        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AT_CRUDContext context)
        {
            _logger = logger;
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var aniversariantes = await _context.Amigo
                .Where(a => a.Aniversario.AddYears(DateTime.Now.Year - a.Aniversario.Year) >= DateTime.Now.Date &&
                        a.Aniversario.AddYears(DateTime.Now.Year - a.Aniversario.Year) <= DateTime.Now.Date.AddDays(1))
                .ToListAsync();

            var proxaniversarios = await _context.Amigo.Where(a => a.Aniversario.AddYears(DateTime.Now.Year - a.Aniversario.Year) >= DateTime.Now.Date &&
                        a.Aniversario.AddYears(DateTime.Now.Year - a.Aniversario.Year) <= DateTime.Now.Date.AddMonths(1))
                .ToListAsync();


            return View(new AniversarianteViewModel 
            { 
                Aniversariantes = aniversariantes, ProximosAniversariantes = proxaniversarios 
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
