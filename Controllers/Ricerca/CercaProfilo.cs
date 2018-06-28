
using Abitasharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Ricerca
{
    public class CercaProfilo : Controller , ICercaProfilo
    {
        private ApplicationContext _context;
        private ILogger<CercaProfilo> _logger;
        public CercaProfilo(ApplicationContext context, ILogger<CercaProfilo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void cerca()
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            return View("Views/Ricerca/CercaProfilo.cshtml");
        }

        public IActionResult visualizza(String userId)
        {
            Utente user = _context.Utenti.Where(u => u.Id == userId).First();
            if (true)
            {
                ViewData["Nome"] = ((ProfiloPrivato) user).Nome;
                ViewData["Cognome"] = ((ProfiloPrivato)user).Cognome;
                ViewData["Email1"] = ((ProfiloPrivato)user).Recapiti.Email1;
                ViewData["Email2"] = ((ProfiloPrivato)user).Recapiti.Email2;
                ViewData["Email3"] = ((ProfiloPrivato)user).Recapiti.Email3;
                ViewData["Tel1"] = ((ProfiloPrivato)user).Recapiti.Tel1;
                ViewData["Tel2"] = ((ProfiloPrivato)user).Recapiti.Tel2;
                ViewData["Tel3"] = ((ProfiloPrivato)user).Recapiti.Tel3;

                return View("Views/GestioneProfilo/ProfiloPrivato.cshtml");
            }

        }
    }
}
