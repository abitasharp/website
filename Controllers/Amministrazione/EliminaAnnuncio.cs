
using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Amministrazione
{
    public class EliminaAnnuncio : Controller , IEliminaAnnuncio
    {
        private ApplicationContext _context;
        private ILogger<EliminaAnnuncio> _logger;
        public EliminaAnnuncio(ApplicationContext context, ILogger<EliminaAnnuncio> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<IActionResult> elimina(EliminaAnnuncioValidator data)
        {
            Annuncio annuncio = _context.Annunci.Where(a => a.ID == data.AnnuncioId).First();
            _context.Annunci.Remove(annuncio);
            _context.SaveChanges();
            _logger.LogInformation("Annuncio destroyed");
            return RedirectToAction(nameof(DashboardController.Index), null);
        }

        public IActionResult show()
        {
            return View("Views/Amministrazione/EliminaAnnuncio.cshtml");
        }
    }
}
