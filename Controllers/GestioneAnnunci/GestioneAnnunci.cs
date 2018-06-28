using Abitasharp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public class GestioneAnnunci : Controller, IGestioneAnnunci
    {
        private readonly UserManager<Utente> _userManager;
        private readonly ApplicationContext _context;
        private readonly ILogger<GestioneAnnunci> _logger;
        private readonly IHttpContextAccessor _httpContext;

        public GestioneAnnunci(ApplicationContext context,
            UserManager<Utente> userManager,
            ILogger<GestioneAnnunci> logger,
            IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _httpContext = httpContext;
        }

        public IActionResult show()
        {
            string uId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Task<Utente> u = _userManager.FindByIdAsync(uId);
            Task.WaitAll(u);

            ICollection<Annuncio> listaAnnunci = ((UtenteRegolare) u.Result).ListaAnnunci;
            ICollection<string> favIds = new List<string>();
            foreach (Preferiti p in ((UtenteRegolare)u.Result).ListaPreferiti ?? new List<Preferiti>()) {
                favIds.Add(p.AnnuncioId);
            }
            ICollection<Annuncio> listaPreferiti = _context.Annunci.Where(a => favIds.Contains(a.ID)).ToList();

            ViewData["ListaAnnunci"] = listaAnnunci;
            ViewData["ListaPreferiti"] = listaPreferiti;
            return View("Views/GestioneAnnunci/GestioneAnnunci.cshtml");
        }
    }
}
