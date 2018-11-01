
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
    public class BannaUtente : Controller , IBannaUtente
    {
        private ApplicationContext _context;
        private ILogger<BannaUtente> _logger;
        public BannaUtente(ApplicationContext context, ILogger<BannaUtente> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> ban(BannaUtenteValidator data)
        {
            Utente utente = _context.Utenti.Where(u => u.Id == data.UtenteId).First();
            _context.Utenti.Remove(utente);
            _context.SaveChanges();
            _logger.LogInformation("User banned");
            return RedirectToAction(nameof(DashboardController.Index), null);
        }

        public IActionResult show()
        {
            return View("Views/Amministrazione/BannaUtente.cshtml");
        }
    }
}
